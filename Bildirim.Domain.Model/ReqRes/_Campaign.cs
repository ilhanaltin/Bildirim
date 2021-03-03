using Bildirim.Domain.Model.Campaigns;
using Bildirim.Domain.Model.Shared;
using Bildirim.Domain.Model.Types;
using System;
using System.Collections.Generic;

namespace Bildirim.Domain.Model.ReqRes
{
    public class GetPostRequest
    {
        public long Id { get; set; }
    }

    public class CampaignListRequest
    {
        public int ItemCount { get; set; }
        public int PageId { get; set; }
        public int? NotificationStatusId { get; set; }

        public int? OwnerBrandId { get; set; }
    }

    public class CampaignListResponseDetails
    {
        public List<CampaignVM> CampaignList { get; set; }

        public PagingVM PagingVM { get; set; }
    }

    public class CampaignResponseDetails
    {
        public CampaignVM Campaign { get; set; }
    }

    public class CampaignPostRequest
    {
        public long NotificationId { get; set; }

        public string Name { get; set; }

        public long NotificationTypeId { get; set; }

        public long NotificationStatusTypeId { get; set; }

        public int ReadCount { get; set; }

        public long CountryId { get; set; }

        public long? CityId { get; set; }

        public long? CountyId { get; set; }

        public string Message { get; set; }

        public long Id { get; set; }

        public long CampaignTypeId { get; set; }

        public string DetailLink { get; set; }

        public string MainImageLink { get; set; }

        public string LogoLink { get; set; }

        public string IconLink { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime? BonusValidityStartDate { get; set; }

        public DateTime? BonusValidityEndDate { get; set; }

        public string DetailText { get; set; }

        public long OwnerBrandId { get; set; }

        public long? BrandId { get; set; }

        public long? SectorId { get; set; }
    }

    public class NotificationStatusPostRequest
    {
        public List<long> NotificationIds { get; set; }

        public long NotificationStatusTypeId { get; set; }
    }
}
