using Bildirim.Domain.Entities.Entity;

namespace Bildirim.Domain.Entity.Entities.Shared
{
    public class County : BaseEntity
    {
        public long CityId { get; set; }

        public virtual City City { get; set; }

        public string Adi { get; set; }
    }
}