using Bildirim.Domain.Entities.Entity;
using Bildirim.Domain.Entity.Entities.Authorization;
using Bildirim.Domain.Entity.Entities.Types;

namespace Bildirim.Domain.Entity.Entities.Notify
{
    public class UserFavoriteNotifications : BaseEntity
    {
        public long UserId { get; set; }

        public virtual User User { get; set; }

        public long NotificationTypeId { get; set; }

        public virtual NotificationType NotificationType { get; set; }        
    }
}
