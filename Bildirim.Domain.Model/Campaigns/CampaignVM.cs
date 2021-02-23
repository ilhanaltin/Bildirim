using Bildirim.Domain.Model.Notify;
using System;

namespace Bildirim.Domain.Model.Campaigns
{
    public class CampaignVM : BaseVM
    {
        public NotificationVM Notification { get; set; }

        public long CampaignTypeId { get; set; }

        public string CampaignTypeAdi { get; set; }

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
        public string OwnerBrandAdi { get; set; }

        public long? BrandId { get; set; }
        public string BrandAdi { get; set; }

        public long? SectorId { get; set; }
        public string SectorAdi { get; set; }
    }
}
