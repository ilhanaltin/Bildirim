using Bildirim.Domain.Entities.Entity;
using Bildirim.Domain.Entity.Entities.Notify;
using Bildirim.Domain.Entity.Entities.Shared;
using Bildirim.Domain.Entity.Entities.Types;
using System;

namespace Bildirim.Domain.Entity.Entities.Campaigns
{
    public class Campaign : BaseEntity
    {
        public long NotificationId { get; set; }

        public Notification Notification { get; set; }

        public string DetailLink { get; set; }

        public string MainImageLink { get; set; }

        public string LogoLink { get; set; }

        public string IconLink { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime? BonusValidityStartDate { get; set; }

        public DateTime? BonusValidityEndDate { get; set; }

        public string DetailText { get; set; }

        public long? CompanyId { get; set; }

        public virtual Company Company { get; set; }

        public long? BrandId { get; set; }

        public virtual Brand Brand { get; set; }

        public long? SectorTypeId { get; set; }

        public virtual SectorType SectorType { get; set; }
    }
}
