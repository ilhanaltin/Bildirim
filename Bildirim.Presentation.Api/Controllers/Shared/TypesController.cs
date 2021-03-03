using AutoMapper;
using Bildirim.Common.Types;
using Bildirim.Domain.Entity.Entities.Shared;
using Bildirim.Domain.Model.ReqRes;
using Bildirim.Domain.Model.Shared;
using Bildirim.Domain.Model.Types;
using Bildirim.Infrastructure.Main.UnitOfWork;
using EasyCaching.Core;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Bildirim.Presentation.Api.Controllers.Shared
{
    [ApiController]
    [Route("api/[controller]")]
    public class TypesController : BaseController
    {
        private readonly IEasyCachingProviderFactory _factory;

        public TypesController(IUnitOfWork unitOfWork, IMapper mapper, IEasyCachingProviderFactory factory)
            : base(unitOfWork, mapper)
        {
            this._factory = factory;
        }

        [HttpGet("GetBrands")]
        public ServiceResult<BrandResponseDetails> GetBrands([FromQuery] GetBrandRequest request)
        {
            var response = new ServiceResult<BrandResponseDetails>();

            var brands = _unitOfWork.BrandRepository.GetAll()
                .Where(t => t.CountryId == request.CountryId)
                .ToList();

            var brandsVM = _mapper.Map<List<Brand>, List<TypeVM>>(brands);

            response.Status = HttpStatusCode.OK;
            response.Result.Brands = brandsVM;

            response.Status = HttpStatusCode.OK;
            return response;
        }

        [HttpGet("GetSectors")]
        public ServiceResult<SectorResponseDetails> GetSectors([FromQuery] GetSectorRequest request)
        {
            var response = new ServiceResult<SectorResponseDetails>();

            var sectors = _unitOfWork.SectorRepository.GetAll()
                .Where(t => t.CountryId == request.CountryId)
                .ToList();

            var sectorsVM = _mapper.Map<List<Sector>, List<TypeVM>>(sectors);

            response.Status = HttpStatusCode.OK;
            response.Result.Sectors = sectorsVM;

            response.Status = HttpStatusCode.OK;
            return response;
        }

        [HttpGet("GetCity")]
        public ServiceResult<CityResponseDetails> GetCity([FromQuery] GetCityRequest request)
        {
            var response = new ServiceResult<CityResponseDetails>();

            var cities = _unitOfWork.CityRepository.GetAll()
                .Where(t => t.CountryId == request.CountryId)
                .ToList();

            var citiesVM = _mapper.Map<List<City>, List<CityVM>>(cities);

            response.Status = HttpStatusCode.OK;
            response.Result.Cities = citiesVM;

            response.Status = HttpStatusCode.OK;
            return response;
        }

        [HttpGet("GetCounty")]
        public ServiceResult<CountyResponseDetails> GetCounty([FromQuery] GetCountyRequest request)
        {
            var response = new ServiceResult<CountyResponseDetails>();

            var counties = _unitOfWork.CountyRepository.GetAll()
                .Where(t => t.CityId == request.CityId)
                .ToList();

            var countiesVM = _mapper.Map<List<County>, List<CountyVM>>(counties);

            response.Status = HttpStatusCode.OK;
            response.Result.Counties = countiesVM;

            response.Status = HttpStatusCode.OK;
            return response;
        }
    }
}