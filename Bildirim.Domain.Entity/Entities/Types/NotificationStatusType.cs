using Bildirim.Domain.Entities.Entity;

namespace Bildirim.Domain.Entity.Entities.Types
{
    public class NotificationStatusType : BaseEntity
    {
        public string Adi { get; set; }

        public int ParentId { get; set; }
    }
}
