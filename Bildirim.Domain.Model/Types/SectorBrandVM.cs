using System.Collections.Generic;

namespace Bildirim.Domain.Model.Types
{
    public class SectorBrandVM
    {
        public long SectorId { get; set; }
        public string SectorAdi { get; set; }
        public List<BrandVM> BrandList { get; set; }
    }

    public class SectorBrandFavoriteCountVM
    {
        public long SectorId { get; set; }
        public string SectorAdi { get; set; }
        public List<BrandVM> BrandList { get; set; }
        public int FavoriteCount { get; set; }
    }
}
