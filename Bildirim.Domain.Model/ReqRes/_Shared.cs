using Bildirim.Domain.Model.Shared;
using Bildirim.Domain.Model.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bildirim.Domain.Model.ReqRes
{
    public class GetBrandRequest
    {
        public long CountryId { get; set; }
        public long SectorId { get; set; }
        public long? UserId { get; set; }
    }

    public class GetBrandForAdminRequest
    {
        public int ItemCount { get; set; }
        public int PageId { get; set; }
        public long CountryId { get; set; }
    }

    public class BrandListResponseDetails
    {
        public List<BrandVM> Brands { get; set; }
        public PagingVM PagingVM { get; set; }
    }

    public class BrandFavoritesResponseDetails
    {
        public List<SectorBrandVM> SectorBrandList { get; set; }
    }

    public class SaveUpdateBrandRequest
    {
        public long? Id { get; set; }
        public string Adi { get; set; }
        public string KisaAdi { get; set; }
        public string Image { get; set; }
    }

    public class GetSectorRequest
    {
        public int ItemCount { get; set; }
        public int PageId { get; set; }
        public long CountryId { get; set; }
    }

    public class SaveUpdateSectorRequest
    {
        public long? Id { get; set; }
        public string Adi { get; set; }
        public string KisaAdi { get; set; }
        public string Image { get; set; }
    }

    public class SectorListResponseDetails
    {
        public List<SectorVM> Sectors { get; set; }
        public PagingVM PagingVM { get; set; }
    }    

    public class GetCityRequest
    {
        public long CountryId { get; set; }
    }

    public class CityResponseDetails
    {
        public List<CityVM> Cities { get; set; }
    }

    public class GetCountyRequest
    {
        public long CityId { get; set; }
    }

    public class CountyResponseDetails
    {
        public List<CountyVM> Counties { get; set; }
    }
}
