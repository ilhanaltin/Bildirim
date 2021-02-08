using Bildirim.Domain.Entities.Entity;
using Bildirim.Domain.Entity.Entities.Types;

namespace Bildirim.Domain.Entity.Entities.Authorization
{
    public class UserRole : BaseEntity
    {
        public long UserId { get; set; }

        public virtual User User { get; set; }

        public long RoleTypeId { get; set; }

        public virtual RoleType RoleType { get; set; }
    }
}
