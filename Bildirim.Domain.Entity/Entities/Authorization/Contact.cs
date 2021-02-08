
using Bildirim.Domain.Entities.Entity;

namespace Bildirim.Domain.Entity.Entities.Authorization
{
    public class Contact : BaseEntity
    {
        public long? UserId { get; set; }
        public virtual User User { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Gsm { get; set; }
        public string Message { get; set; }
    }
}
