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

        public long NotificationTypeId { get; set; }

        public virtual NotificationType NotificationType { get; set; }

        public long NotificationStatusTypeId { get; set; }

        public virtual NotificationStatusType NotificationStatusType { get; set; }

        public int ReadCount { get; set; }

        public long CountryId { get; set; }

        public virtual Country Country { get; set; }

        public long? CityId { get; set; }

        public virtual City City { get; set; }

        public long? CountyId { get; set; }

        public virtual County County { get; set; }

        public virtual List<NotificationVote> NotificationVotes { get; set; }
    }
}
