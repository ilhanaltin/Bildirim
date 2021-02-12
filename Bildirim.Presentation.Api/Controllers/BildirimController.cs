using AutoMapper;
using Bildirim.Common;
using Bildirim.Common.Helpers;
using Bildirim.Domain.Entity.Entities.Campaigns;
using Bildirim.Domain.Entity.Entities.Notify;
using Bildirim.Infrastructure.Main.UnitOfWork;
using Bildirim.Presentation.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bildirim.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BildirimController : BaseController
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public BildirimController(IUnitOfWork unitOfWork, IMapper mapper, ILogger<WeatherForecastController> logger)
            : base(unitOfWork, mapper)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            // instance or static variable
            HttpClient client = new HttpClient();

            // get answer in non-blocking way
            using (var response = await client.GetAsync("https://www.bonus.com.tr/kampanyalar"))
            {
                using (var content = response.Content)
                {
                    try
                    {
                        var result = await content.ReadAsStringAsync();
                        var document = new HtmlAgilityPack.HtmlDocument();
                        document.LoadHtml(result);
                        var nodes = document.DocumentNode.SelectNodes("//div[contains(@class, 'campaign-box check-box-item')]");

                        foreach (var node in nodes)
                        {
                            var notify = new Notification();
                            var campaign = new Campaign();

                            notify.Name = node.Attributes["data-text"].Value;
                            notify.NotificationStatusTypeId = Constants.NOTIFICATION_STATUS_TYPE_WAITING_APPROVE;
                            notify.NotificationTypeId = Constants.NOTIFICATION_TYPE_COMPAIGN_PERSONAL;
                            notify.CountryId = 1;
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

                                        var startEndDate = DateTimeHelper.GetStartEndDateFromString(startEndDateStr);

                                        campaign.StartDate = startEndDate.StartDate;
                                        campaign.EndDate = startEndDate.EndDate;

                                        var sectorAndBrand = nodeDetail.Descendants("div")
                                                .Where(d => d.Attributes["class"] != null && d.Attributes["class"].Value.Contains("campaign-detail__brand-sector"))
                                                .FirstOrDefault();

                                        var btnlandingcapsule = nodeDetail.Descendants("div")
                                                .Where(d => d.Attributes["class"] != null && d.Attributes["class"].Value.Contains("btn-landing-capsule"))
                                                .FirstOrDefault();

                                        var detailHtmlLeft = nodeDetail.Descendants("div")
                                                .Where(d => d.Attributes["class"] != null && d.Attributes["class"].Value.Contains("campaign-detail__info campaign-detail__info--left"))
                                                .FirstOrDefault();
                                                
                                        if(sectorAndBrand!=null)
                                        {
                                            detailHtmlLeft = detailHtmlLeft.RemoveChild(sectorAndBrand);
                                        }

                                        if (btnlandingcapsule != null)
                                        {
                                            detailHtmlLeft = detailHtmlLeft.RemoveChild(btnlandingcapsule);
                                        }

                                        //notify.DetailText
                                    }
                                    catch (Exception e)
                                    {

                                    }
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                    }

                }
            }

            return Ok(null);
        }
    }
}
