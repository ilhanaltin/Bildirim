using Bildirim.Domain.Entities.Entity;

namespace Bildirim.Domain.Entity.Entities.Shared
{
    public class Sector : BaseEntity
    {
        public long CountryId { get; set; }

        public virtual Country Country { get; set; }

        public string Adi { get; set; }

        public string KisaAdi { get; set; }

        public string Image { get; set; }
    }
}
