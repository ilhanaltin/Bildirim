namespace Bildirim.Domain.Model.Types
{
    public class BrandVM
    {
        public long Id { get; set; }
        public string Adi { get; set; }
        public string KisaAdi { get; set; }
        public string UzunAdi { get; set; }

        public string Image { get; set; }
        public bool IsFavorite { get; set; }
    }
}
