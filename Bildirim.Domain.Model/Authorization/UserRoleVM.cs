using Bildirim.Domain.Model.Types;

namespace Bildirim.Domain.Model.Authorization
{
    public class UserRoleVM : BaseVM
    {
        public long UserId { get; set; }

        public virtual UserVM User { get; set; }

        public long RoleTypeId { get; set; }

        public virtual TypeVM RoleType { get; set; }

    }
}
