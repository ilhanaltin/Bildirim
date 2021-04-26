using Bildirim.Domain.Entities.Entity;
using Bildirim.Domain.Entity.Entities.Campaigns;
using Bildirim.Domain.Entity.Entities.Notify;
using Bildirim.Domain.Entity.Entities.Types;
using System.Collections.Generic;

namespace Bildirim.Domain.Entity.Entities.Authorization
{
    public class User : BaseEntity
    {
        public User()
        {
            this.IsBlocked = false;
            this.UserRoles = new List<UserRole>();
        }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string NickName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public long UserLoginTypeId { get; set; }

        public virtual UserLoginType UserLoginType { get; set; }

        public string SocialMediaUserId { get; set; }

        public long UserStatusTypeId { get; set; }

        public virtual UserStatusType UserStatusType { get; set; }

        public bool IsBlocked { get; set; }

        public virtual List<UserRole> UserRoles { get; set; }

        public virtual List<UserFavoriteCategories> UserFavoriteCategories { get; set; }
    }
}
