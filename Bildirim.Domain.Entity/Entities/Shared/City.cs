using Bildirim.Domain.Entities.Entity;

namespace Bildirim.Domain.Entity.Entities.Shared
{
    public class City : BaseEntity
    {
        public long CountryId { get; set; }

        public virtual Country Country { get; set; }

        public string Adi { get; set; }

        public int Kod { get; set; }
    }
}
