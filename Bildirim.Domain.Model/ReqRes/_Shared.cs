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

    public class BrandResponseDetails
    {
        public List<BrandVM> Brands { get; set; }
    }

    public class GetSectorRequest
    {
        public long CountryId { get; set; }
    }

    public class SectorResponseDetails
    {
        public List<TypeVM> Sectors { get; set; }
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
