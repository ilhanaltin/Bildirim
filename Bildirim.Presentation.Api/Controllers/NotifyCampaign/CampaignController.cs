using AutoMapper;
using Bildirim.Common.Types;
using Bildirim.Domain.Entity.Entities.Campaigns;
using Bildirim.Domain.Entity.Entities.Notify;
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

            var campaignsQuery = _unitOfWork.CampaignRepository.GetAllIncluding(x => x.Brand,
                                                                                x => x.OwnerBrand,
                                                                                t => t.CampaignType,
                                                                                t => t.Notification,
                                                                                t => t.Notification.NotificationVotes,
                                                                                t => t.Sector);

            if (request.NotificationStatusId.HasValue && request.NotificationStatusId.Value > 0)
            {
                campaignsQuery = campaignsQuery.Where(t => t.Notification.NotificationStatusTypeId == request.NotificationStatusId.Value);
            }

            if (request.OwnerBrandId.HasValue && request.OwnerBrandId.Value > 0)
            {
                campaignsQuery = campaignsQuery.Where(t => t.OwnerBrandId == request.OwnerBrandId);
            }

            /*if (request.BrandId.HasValue && request.BrandId.Value > 0)
            {
                campaignsQuery = campaignsQuery.Where(t => t.BrandId == request.BrandId);
            }

            if (request.SectorId.HasValue && request.SectorId.Value > 0)
            {
                campaignsQuery = campaignsQuery.Where(t => t.SectorId == request.SectorId);
            }*/

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

            var campaign = new Campaign();
            var notifcation = new Notification();

            if (request.Id > 0)
            {
                campaign = _unitOfWork.CampaignRepository.GetIncluding(t => t.Id == request.Id, x => x.Notification);
                notifcation = campaign.Notification;
            }

            _mapper.Map<CampaignPostRequest, Campaign>(request, campaign);

            _mapper.Map<CampaignPostRequest, Notification>(request, notifcation);

            campaign.Notification = notifcation;

            _unitOfWork.StartTransaction();

            try
            {
                if (request.Id > 0)
                {
                    _unitOfWork.NotificationRepository.Update(notifcation);

                    _unitOfWork.CampaignRepository.Update(campaign);
                }
                else
                {

                    _unitOfWork.NotificationRepository.Add(notifcation);

                    _unitOfWork.CampaignRepository.Add(campaign);
                }

                _unitOfWork.Commit();
            }
            catch (Exception ex)
            {

                response.Status = HttpStatusCode.InternalServerError;

                return response;
            }

            var campaignVM = _mapper.Map<Campaign, CampaignVM>(campaign);

            response.Status = HttpStatusCode.OK;
            response.Result.Campaign = campaignVM;
            return response;
        }

        [HttpPost("UpdateStatus")]
        public ServiceResult<StandartResponseDetails> UpdateStatus([FromBody] NotificationStatusPostRequest request)
        {
            var response = new ServiceResult<StandartResponseDetails>();

            var notifications = _unitOfWork.NotificationRepository
                    .GetAll()
                    .Where(t => request.NotificationIds.Contains(t.Id))
                    .ToList();

            notifications.ForEach(c => c.NotificationStatusTypeId = request.NotificationStatusTypeId);

            foreach (var item in notifications)
            {
                _unitOfWork.NotificationRepository.Update(item);
            }

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

        [HttpPost("UpdateUserFavorites")]
        public ServiceResult<StandartResponseDetails> UpdateUserFavorites([FromBody] UpdateUserFavoritesRequest request)
        {
            var response = new ServiceResult<StandartResponseDetails>();

            var favoriteItem = _unitOfWork.UserFavoriteCategoriesRepository
                .Get(t => t.SectorId == request.SectorId && t.BrandId == request.BrandId && t.UserId == request.UserId);

            if(favoriteItem != null && favoriteItem.Id > 0)
            {
                _unitOfWork.UserFavoriteCategoriesRepository.Remove(favoriteItem);
            }
            else
            {
               var favoriteCategory = _mapper.Map<UpdateUserFavoritesRequest, UserFavoriteCategories>(request);
                _unitOfWork.UserFavoriteCategoriesRepository.Add(favoriteCategory);
            }
            response.Status = HttpStatusCode.OK;

            return response;
        }
    }
}
