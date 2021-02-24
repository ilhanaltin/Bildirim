using AutoMapper;
using Bildirim.Common.Types;
using Bildirim.Domain.Entity.Entities.Campaigns;
using Bildirim.Domain.Entity.Entities.Shared;
using Bildirim.Domain.Model.Campaigns;
using Bildirim.Domain.Model.ReqRes;
using Bildirim.Domain.Model.Shared;
using Bildirim.Domain.Model.Types;
using Bildirim.Infrastructure.Main.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Bildirim.Presentation.Api.Controllers.NotifyCampaign
{
    [ApiController]
    [Route("api/[controller]")]
    public class CampaignController : BaseController
    {
        private readonly ILogger<CampaignController> _logger;

        public CampaignController(IUnitOfWork unitOfWork, IMapper mapper, ILogger<CampaignController> logger)
            : base(unitOfWork, mapper)
        {
            _logger = logger;
        }

        [HttpGet]
        public ServiceResult<CampaignListResponseDetails> Get([FromQuery] CampaignListRequest request)
        {
            var response = new ServiceResult<CampaignListResponseDetails>();

            var campaignsQuery = _unitOfWork.CampaignRepository.GetAll()
                                    .Include(x => x.Brand)
                                    .Include(x => x.OwnerBrand)
                                    .Include(t => t.CampaignType)
                                    .Include(t => t.Notification).ThenInclude(x=>x.NotificationVotes)
                                    .Include(t => t.Sector);

            var paging = new PagingVM();
            paging.TotalCount = campaignsQuery.Count();
            paging.TotalPage = Math.Ceiling(((decimal)paging.TotalCount / request.ItemCount));
            paging.CurrentPage = request.PageId;
            paging.PageItemCount = request.ItemCount;

            var campaigns = campaignsQuery.OrderByDescending(o => o.Id).Skip((request.PageId) * request.ItemCount)
                    .Take(request.ItemCount).ToList();

            var campaignsVM = _mapper.Map<List<Campaign>, List<CampaignVM>>(campaigns);

            response.Status = HttpStatusCode.OK;
            response.Result.CampaignList = campaignsVM;
            response.Result.PagingVM = paging;

            response.Status = HttpStatusCode.OK;
            return response;
        }

        [HttpPost]
        public ServiceResult<CampaignResponseDetails> Post([FromBody] CampaignPostRequest request)
        {
            var response = new ServiceResult<CampaignResponseDetails>();

            response.Status = HttpStatusCode.OK;
            return response;
        }

        [HttpGet("GetById")]
        public ServiceResult<CampaignResponseDetails> GetById([FromQuery] GetPostRequest request)
        {
            var campaign = _unitOfWork.CampaignRepository
                .GetIncluding(t => t.Id == request.Id,
                                x => x.Brand, 
                                x => x.OwnerBrand, 
                                x => x.CampaignType, 
                                x => x.Notification, 
                                x => x.Notification.NotificationVotes, 
                                x => x.Sector);

            var campaignVM = _mapper.Map<Campaign, CampaignVM>(campaign);

            var response = new ServiceResult<CampaignResponseDetails>();

            response.Result.Campaign = campaignVM;
            response.Status = HttpStatusCode.OK;

            return response;
        }

        [HttpPost("Delete")]
        public ServiceResult<StandartResponseDetails> Delete([FromBody] DeleteRequest request)
        {
            var response = new ServiceResult<StandartResponseDetails>();

            var campaign = _unitOfWork.CampaignRepository.GetIncluding(t => t.Id == request.Id, x => x.Notification);

            if (campaign == null)
            {
                response.Status = HttpStatusCode.NotFound;
                return response;
            }

            _unitOfWork.StartTransaction();

            try
            {
                _unitOfWork.NotificationRepository.Remove(campaign.Notification);
                //_unitOfWork.NotificationVotesRepository.Remove(campaign.Notification.NotificationVotes);
                _unitOfWork.CampaignRepository.Remove(campaign);

                _unitOfWork.Commit();

                response.Status = HttpStatusCode.OK;
            }
            catch (Exception)
            {
                response.Status = HttpStatusCode.InternalServerError;
            }

            return response;
        }

        [HttpGet("GetBrands")]
        public ServiceResult<BrandResponseDetails> GetBrands([FromQuery] GetBrandRequest request)
        {
            var response = new ServiceResult<BrandResponseDetails>();

            var brands = _unitOfWork.BrandRepository.GetAll()
                .Where(t=>t.CountryId == request.CountryId)
                .ToList();

            var brandsVM = _mapper.Map<List<Brand>, List<TypeVM>>(brands);

            response.Status = HttpStatusCode.OK;
            response.Result.Brands = brandsVM;

            response.Status = HttpStatusCode.OK;
            return response;
        }
    }
}
