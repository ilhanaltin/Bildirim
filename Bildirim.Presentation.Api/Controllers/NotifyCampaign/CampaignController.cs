using AutoMapper;
using Bildirim.Common.Types;
using Bildirim.Domain.Entity.Entities.Campaigns;
using Bildirim.Domain.Model.Campaigns;
using Bildirim.Domain.Model.ReqRes;
using Bildirim.Domain.Model.Shared;
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
                                    .Include(t => t.Notification)
                                    .Include(t => t.Sector);

            var paging = new PagingVM();
            paging.TotalCount = campaignsQuery.Count();
            paging.TotalPage = Math.Ceiling(((decimal)paging.TotalCount / request.ItemCount));
            paging.CurrentPage = request.PageId;
            paging.PageItemCount = request.ItemCount;

            var campaigns = campaignsQuery.OrderByDescending(o => o.Id).Skip((request.PageId - 1) * request.ItemCount)
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
    }
}
