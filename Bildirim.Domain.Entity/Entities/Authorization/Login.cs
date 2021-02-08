
using Bildirim.Domain.Entities.Entity;

namespace Bildirim.Domain.Entity.Entities.Authorization
{
    public class Login : BaseEntity
    {
        public long UserId { get; set; }
        public virtual User User { get; set; }
        public string SessionId { get; set; }
        public bool LoggedIn { get; set; }
    }
}
