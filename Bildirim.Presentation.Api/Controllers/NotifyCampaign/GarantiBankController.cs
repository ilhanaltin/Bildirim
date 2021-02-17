using AutoMapper;
using Bildirim.Common;
using Bildirim.Common.Helpers;
using Bildirim.Common.Types;
using Bildirim.Domain.Entity.Entities.Campaigns;
using Bildirim.Domain.Entity.Entities.Notify;
using Bildirim.Domain.Entity.Entities.Shared;
using Bildirim.Domain.Model.ReqRes;
using Bildirim.Infrastructure.Main.UnitOfWork;
using Bildirim.Presentation.Api.Controllers;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bildirim.Presentation.Api.NotifyCampaign.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GarantiBankController : BaseController
    {
        private readonly ILogger<GarantiBankController> _logger;

        public GarantiBankController(IUnitOfWork unitOfWork, IMapper mapper, ILogger<GarantiBankController> logger)
            : base(unitOfWork, mapper)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<ServiceResult<StandartResponseDetails>> Get()
        {
            var response = new ServiceResult<StandartResponseDetails>();

            // instance or static variable
            HttpClient client = new HttpClient();

            // get answer in non-blocking way
            using (var responseOfWebPage = await client.GetAsync("https://www.bonus.com.tr/kampanyalar"))
            {
                using (var content = responseOfWebPage.Content)
                {
                    try
                    {
                        var result = await content.ReadAsStringAsync();
                        var document = new HtmlAgilityPack.HtmlDocument();
                        document.LoadHtml(result);

                        var mainBrand = _unitOfWork.BrandRepository.Get(t => t.Adi.Equals("Garanti Bankası") && t.CountryId == Constants.COUNTRY_TURKEY);

                        if (mainBrand == null)
                        {
                            response.Status = HttpStatusCode.NotFound;
                            response.Messages.Add("Main brand not found");
                            return response;
                        }

                        var nodes = document.DocumentNode.SelectNodes("//div[contains(@class, 'campaign-box check-box-item')]");

                        foreach (var node in nodes)
                        {
                            var notify = new Notification();
                            var campaign = new Campaign();

                            notify.Name = node.Attributes["data-text"].Value;
                            notify.NotificationStatusTypeId = Constants.NOTIFICATION_STATUS_TYPE_WAITING_APPROVE;
                            notify.NotificationTypeId = Constants.NOTIFICATION_TYPE_COMPAIGN;
                            notify.CountryId = Constants.COUNTRY_TURKEY;
                            notify.CreatedUserId = 1;

                            _unitOfWork.NotificationRepository.Add(notify);

                            campaign.NotificationId = notify.Id;

                            campaign.DetailLink = node.Descendants("a").Where(d => d.Attributes["class"].Value.Contains("direct"))
                                                .FirstOrDefault()
                                                .Attributes["href"].Value;

                            campaign.MainImageLink = node.Descendants("img").Where(d => d.Attributes["class"].Value.Contains("campaign-box__image"))
                                                        .FirstOrDefault()
                                                        .Attributes["src"].Value;

                            campaign.LogoLink = node.Descendants("img").Where(d => d.Attributes["class"].Value.Contains("campaign-box__brand-logo"))
                                                        .FirstOrDefault()
                                                        .Attributes["src"].Value;

                            var icondiv = node.Descendants("div").Where(d => d.Attributes["class"].Value.Contains("campaign-box__icon"))
                                                        .FirstOrDefault();

                            if (icondiv != null)
                            {
                                campaign.IconLink = icondiv.Descendants("img").FirstOrDefault().Attributes["src"].Value;
                            }

                            // get answer in non-blocking way
                            using (var responseDetail = await client.GetAsync("https://www.bonus.com.tr" + campaign.DetailLink))
                            {
                                using (var contentDetail = responseDetail.Content)
                                {
                                    try
                                    {
                                        var resultDetail = await contentDetail.ReadAsStringAsync();
                                        var documentDetail = new HtmlAgilityPack.HtmlDocument();
                                        documentDetail.LoadHtml(resultDetail);
                                        var nodeDetail = documentDetail.DocumentNode.SelectSingleNode("//div[contains(@class, 'campaign-detail__content')]");

                                        var startEndDateStr = nodeDetail.Descendants("p")
                                                                       .Where(d => d.Attributes["class"] != null && d.Attributes["class"].Value.Contains("campaign-date"))
                                                                       .FirstOrDefault().InnerHtml;

                                        campaign.CampaignTypeId = Constants.CAMPAIGN_TYPE_PERSONAL;
                                        campaign.OwnerBrandId = mainBrand.Id;

                                        var startEndDate = DateTimeHelper.GetStartEndDateFromString(startEndDateStr);

                                        if(startEndDate != null)
                                        {
                                            campaign.StartDate = startEndDate.StartDate;
                                            campaign.EndDate = startEndDate.EndDate;
                                        }
                                        else
                                        {
                                            notify.Message += "Campaign start date couldn't evaluated. Date String :" + startEndDateStr;
                                            notify.NotificationStatusTypeId = Constants.NOTIFICATION_STATUS_TYPE_ERROR;
                                            _unitOfWork.NotificationRepository.Update(notify);
                                        }

                                        var startEndDateOfBonusValidityDOM = nodeDetail.Descendants("p")
                                                                       .Where(d => d.Attributes["class"] != null && d.Attributes["class"].Value.Contains("bonus-date"))
                                                                       .FirstOrDefault();

                                        if (startEndDateOfBonusValidityDOM != null)
                                        {
                                            var startEndDateOfBonusValidity = DateTimeHelper.GetStartEndDateFromString(startEndDateOfBonusValidityDOM.InnerHtml);

                                            if (startEndDateOfBonusValidity != null)
                                            {
                                                campaign.BonusValidityStartDate = startEndDateOfBonusValidity.StartDate;
                                                campaign.BonusValidityEndDate = startEndDateOfBonusValidity.EndDate;
                                            }
                                            else
                                            {
                                                notify.Message += "\nBonus validity date couldn't evaluated. Date String :" + startEndDateOfBonusValidityDOM.InnerHtml;
                                                notify.NotificationStatusTypeId = Constants.NOTIFICATION_STATUS_TYPE_ERROR;
                                                _unitOfWork.NotificationRepository.Update(notify);
                                            }
                                        }

                                        var sectorAndBrand = nodeDetail.Descendants("div")
                                                .Where(d => d.Attributes["class"] != null && d.Attributes["class"].Value.Contains("campaign-detail__brand-sector"))
                                                .FirstOrDefault();

                                        string sectorStr = sectorAndBrand.InnerText.Split("/")[0].Replace("Sektör:", "").Trim();
                                        string brandStr = sectorAndBrand.InnerText.Split("/")[1].Replace("Marka:", "").Trim();

                                        var sectorEntity = _unitOfWork.SectorRepository.Get(t => t.Adi.Equals(sectorStr));
                                        var brandEntity = _unitOfWork.BrandRepository.Get(t => t.Adi.Equals(brandStr));

                                        if (sectorEntity != null)
                                            campaign.SectorId = sectorEntity.Id;

                                        if (brandEntity != null)
                                            campaign.BrandId = brandEntity.Id;

                                        var btnlandingcapsule = nodeDetail.Descendants("div")
                                                .Where(d => d.Attributes["class"] != null && d.Attributes["class"].Value.Contains("btn-landing-capsule"))
                                                .FirstOrDefault();

                                        var detailHtmlLeft = nodeDetail.Descendants("div")
                                                .Where(d => d.Attributes["class"] != null && d.Attributes["class"].Value.Contains("campaign-detail__info campaign-detail__info--left"))
                                                .FirstOrDefault();

                                        var listToBeRemoved = new List<HtmlNode>();

                                        foreach (var cNode in detailHtmlLeft.ChildNodes)
                                        {
                                            if (cNode.Attributes["class"] != null && cNode.Attributes["class"].Value.Contains("btn-landing-capsule"))
                                            { 
                                                listToBeRemoved.Add(cNode);
                                                continue; 
                                            }

                                            if (cNode.Attributes["class"] != null && cNode.Attributes["class"].Value.Contains("campaign-detail__info campaign-detail__info--left"))
                                            {
                                                listToBeRemoved.Add(cNode);
                                                continue; 
                                            }

                                            cNode.Attributes.Remove("class");
                                            cNode.Attributes.Remove("id");
                                        }

                                        foreach (var rNode in listToBeRemoved)
                                        {
                                            detailHtmlLeft.RemoveChild(rNode);
                                        }

                                        var detailHtmlRight = nodeDetail.Descendants("div")
                                                .Where(d => d.Attributes["class"] != null && d.Attributes["class"].Value.Contains("campaign-detail__info campaign-detail__info--right"))
                                                .FirstOrDefault();

                                        foreach (var cNode in detailHtmlRight.ChildNodes)
                                        {
                                            cNode.Attributes.Remove("class");
                                            cNode.Attributes.Remove("id");
                                        }

                                        campaign.DetailText = detailHtmlLeft.InnerHtml + "<br>" + detailHtmlRight.InnerHtml;

                                        _unitOfWork.CampaignRepository.Add(campaign);
                                    }
                                    catch (Exception e)
                                    {
                                        notify.Message += "\n Error Occured: " + ExceptionHelper.GetExceptionDetails(e);
                                        notify.NotificationStatusTypeId = Constants.NOTIFICATION_STATUS_TYPE_ERROR;
                                        _unitOfWork.NotificationRepository.Update(notify);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        response.Status = HttpStatusCode.InternalServerError;
                        return response;
                    }

                }
            }

            response.Status = HttpStatusCode.OK;
            return response;
        }

        [HttpGet("GetSectorAndBrand")]
        public async Task<ServiceResult<StandartResponseDetails>> GetSectorAndBrand()
        {
            var response = new ServiceResult<StandartResponseDetails>();

            // instance or static variable
            HttpClient client = new HttpClient();

            // get answer in non-blocking way
            using (var responseOfWebPage = await client.GetAsync("https://www.bonus.com.tr/kampanyalar"))
            {
                using (var content = responseOfWebPage.Content)
                {
                    try
                    {
                        var result = await content.ReadAsStringAsync();
                        var document = new HtmlAgilityPack.HtmlDocument();
                        document.LoadHtml(result);

                        var nodesOfBrands = document.DocumentNode.SelectSingleNode("//div[contains(@class, 'campaign-filter__selects-container')]");

                        var optionsOfSectorAndBrand = nodesOfBrands.Descendants("select")
                                .Where(d => d.Attributes["class"].Value
                                .Contains("campaign-filter__select campaign-filter__select"))
                                .ToList();

                        var mainBrand = _unitOfWork.BrandRepository.Get(t => t.Adi.Equals("Garanti Bankası") && t.CountryId == Constants.COUNTRY_TURKEY);

                        if (mainBrand == null)
                        {
                            mainBrand = new Brand
                            {
                                Adi = "Garanti Bankası",
                                CountryId = Constants.COUNTRY_TURKEY,
                                CreatedDateTime = DateTime.Now,
                                CreatedUserId = 1
                            };

                            _unitOfWork.BrandRepository.Add(mainBrand);
                        }

                        var listOfSectors = optionsOfSectorAndBrand[0].InnerText.Split("\r\n").Select(s => s.Trim()).ToArray();

                        foreach (var s in listOfSectors)
                        {
                            if (_unitOfWork.SectorRepository.Any(t => t.Adi.Equals(s) && t.CountryId == Constants.COUNTRY_TURKEY))
                                continue;

                            if (s.Equals("Sektöre Göre Arama") || s.Equals("Tüm Sektörler"))
                                continue;

                            var sector = new Sector
                            {
                                Adi = s,
                                CountryId = Constants.COUNTRY_TURKEY,
                                CreatedDateTime = DateTime.Now,
                                CreatedUserId = 1
                            };

                            _unitOfWork.SectorRepository.Add(sector);
                        }

                        var listOfBrands = optionsOfSectorAndBrand[1].InnerText.Split("\r\n").Select(s => s.Trim()).ToArray();

                        foreach (var b in listOfBrands)
                        {
                            if (_unitOfWork.BrandRepository.Any(t => t.Adi.Equals(b) && t.CountryId == Constants.COUNTRY_TURKEY))
                                continue;

                            if (b.Equals("Markaya Göre Ara") || b.Equals("Tüm Markalar"))
                                continue;

                            var brand = new Brand
                            {
                                Adi = b,
                                CountryId = Constants.COUNTRY_TURKEY,
                                CreatedDateTime = DateTime.Now,
                                CreatedUserId = 1
                            };

                            _unitOfWork.BrandRepository.Add(brand);
                        }
                    }
                    catch (Exception e)
                    {
                        response.Status = HttpStatusCode.InternalServerError;
                        return response;
                    }
                }
            }

            response.Status = HttpStatusCode.OK;
            return response;
        }
    }
}
