namespace Bildirim.Domain.Model.Types
{
    public class SectorVM
    {
        public long Id { get; set; }
        public string Adi { get; set; }
        public string KisaAdi { get; set; }
        public string Image { get; set; }
        public bool IsFavorite { get; set; }
        public int CampaignCount { get; set; }
    }
}
