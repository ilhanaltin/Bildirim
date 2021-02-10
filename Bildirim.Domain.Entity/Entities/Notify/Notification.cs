using Bildirim.Domain.Entities.Entity;
using Bildirim.Domain.Entity.Entities.Shared;
using Bildirim.Domain.Entity.Entities.Types;
using System;
using System.Collections.Generic;

namespace Bildirim.Domain.Entity.Entities.Notify
{
    public class Notification : BaseEntity
    {
        public string Name { get; set; }
        public string DetailLink { get; set; }

        public string MainImageLink { get; set; }

        public string LogoLink { get; set; }

        public string IconLink { get; set; }

        public long NotificationTypeId { get; set; }

        public virtual NotificationType NotificationType { get; set; }

        public long NotificationStatusTypeId { get; set; }

        public virtual NotificationStatusType NotificationStatusType { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string DetailText { get; set; }

        public int ReadCount { get; set; }

        public long CompanyId { get; set; }

        public virtual Company Company { get; set; }

        public long CountryId { get; set; }

        public virtual Country Country { get; set; }

        public long? CityId { get; set; }

        public virtual City City { get; set; }

        public long? CountyId { get; set; }

        public virtual County County { get; set; }

        public virtual List<NotificationVote> NotificationVotes { get; set; }
    }
}
