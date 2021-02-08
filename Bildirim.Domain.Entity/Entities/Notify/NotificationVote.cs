using Bildirim.Domain.Entities.Entity;
using Bildirim.Domain.Entity.Entities.Authorization;

namespace Bildirim.Domain.Entity.Entities.Notify
{
    public class NotificationVote : BaseEntity
    {
        public long UserId { get; set; }

        public virtual User User { get; set; }

        public long NotificationId { get; set; }

        public virtual Notification Notification { get; set; }
    }
}
