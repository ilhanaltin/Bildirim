using Bildirim.Domain.Entities.Entity;

namespace Bildirim.Domain.Entity.Entities.Authorization
{
    public class UserVerification : BaseEntity
    {
        public long UserId { get; set; }

        public string Token { get; set; }

        public bool Active { get; set; }
    }
}
