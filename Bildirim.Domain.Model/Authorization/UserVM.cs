
using System;

namespace Bildirim.Domain.Model.Authorization
{
    public class UserVM : BaseVM
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public string NickName { get; set; }

        public string Email { get; set; }

        public bool Notify { get; set; }

        public long StatusId { get; set; }

        public string StatusName { get; set; }

        public long UserLoginTypeId { get; set; }

        public string SocialMediaUserId { get; set; }

        public long RoleId { get; set; }

        public string RoleName { get; set; }

        public DateTime? LastLoginTime { get; set; }
    }
}
