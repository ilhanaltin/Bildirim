using AutoMapper;
using Bildirim.Common.Types;
using Bildirim.Domain.Entity.Entities.Campaigns;
using Bildirim.Domain.Entity.Entities.Shared;
using Bildirim.Domain.Model.ReqRes;
using Bildirim.Domain.Model.Shared;
using Bildirim.Domain.Model.Types;
using Bildirim.Infrastructure.Main.UnitOfWork;
using EasyCaching.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        [AllowAnonymous]
        public ServiceResult<BrandResponseDetails> GetBrands([FromQuery] GetBrandRequest request)
        {
            var response = new ServiceResult<BrandResponseDetails>();

            var brands = _unitOfWork.BrandRepository.GetAll()
                .Where(t => t.CountryId == request.CountryId)
                .OrderBy(x=> x.Adi)
                .ToList();

            var brandsVM = _mapper.Map<List<Brand>, List<BrandVM>>(brands);

            response.Result.Brands = brandsVM;

            response.Status = HttpStatusCode.OK;
            return response;
        }

        [HttpGet("GetBrandsOfSector")]
        [AllowAnonymous]
        public ServiceResult<BrandResponseDetails> GetBrandsOfSector([FromQuery] GetBrandRequest request)
        {
            var response = new ServiceResult<BrandResponseDetails>();

            var brands = _unitOfWork.CampaignRepository.GetAll()
                .Where(t => t.BrandId != null && t.SectorId == request.SectorId)
                .Include(x=>x.Brand)
                .Select(column => new Brand
                {
                    Id = column.Brand.Id,
                    Adi = column.Brand.Adi
                })
                .Distinct()
                .OrderBy(x => x.Adi)
                .ToList();

            var brandsVM = _mapper.Map<List<Brand>, List<BrandVM>>(brands);

            if(request.UserId.HasValue && request.UserId.Value >0)
            {
                var favorites = _unitOfWork.UserFavoriteCategoriesRepository
                .GetAll()
                .Where(t => t.SectorId == request.SectorId
                        && t.UserId == request.UserId)
                .ToList();

                foreach (var fav in favorites)
                {
                    var itemIndex = brandsVM.FindIndex(x => x.Id == fav.BrandId);
                    var item = brandsVM.ElementAt(itemIndex);
                    item.IsFavorite = true;
                }
            }

            response.Result.Brands = brandsVM;

            response.Status = HttpStatusCode.OK;
            return response;
        }

        [HttpGet("GetFavoriteBrands")]
        [AllowAnonymous]
        public ServiceResult<BrandFavoritesResponseDetails> GetFavoriteBrands([FromQuery] GetBrandRequest request)
        {
            var response = new ServiceResult<BrandFavoritesResponseDetails>();

            var favorites = _unitOfWork.UserFavoriteCategoriesRepository
                .GetAll()
                .Where(t => t.UserId == request.UserId)
                .ToList();

            var favoritesGroupBy = favorites.GroupBy(t => t.SectorId);

            var sectorBrandList = new List<SectorBrandVM>();

            foreach (var sectorGroup in favoritesGroupBy)
            {
                var sectorBrand = new SectorBrandVM();
                sectorBrand.SectorId = sectorGroup.Key;
                sectorBrand.SectorAdi = sectorGroup.FirstOrDefault().Sector.Adi;

                var ids = sectorGroup.ToList().Select(t => t.BrandId);

                var brands = _unitOfWork.BrandRepository.GetAll()
                        .Where(t => ids.Contains(t.Id))
                        .OrderBy(x => x.Adi)
                        .ToList();

                var brandsVM = _mapper.Map<List<Brand>, List<BrandVM>>(brands);
                brandsVM = brandsVM.Select(t => { t.IsFavorite = true; return t; }).ToList();
                sectorBrand.BrandList = brandsVM;

                sectorBrandList.Add(sectorBrand);
            }

            response.Result.SectorBrandList = sectorBrandList;

            response.Status = HttpStatusCode.OK;
            return response;
        }

        [HttpGet("GetSectors")]
        [AllowAnonymous]
        public ServiceResult<SectorResponseDetails> GetSectors([FromQuery] GetSectorRequest request)
        {
            var response = new ServiceResult<SectorResponseDetails>();

            var sectors = _unitOfWork.SectorRepository.GetAll()
                .Where(t => t.CountryId == request.CountryId)
                .OrderBy(x => x.Adi)
                .ToList();

            var sectorsVM = _mapper.Map<List<Sector>, List<TypeVM>>(sectors);

            response.Result.Sectors = sectorsVM;

            response.Status = HttpStatusCode.OK;
            return response;
        }

        [HttpGet("GetFavoriteSectors")]
        [AllowAnonymous]
        public ServiceResult<SectorResponseDetails> GetFavoriteSectors([FromQuery] GetSectorRequest request)
        {
            var response = new ServiceResult<SectorResponseDetails>();

            var sectors = _unitOfWork.SectorRepository.GetAll()
                .Where(t => t.CountryId == request.CountryId)
                .OrderBy(x => x.Adi)
                .Take(10)
                .ToList();

            var sectorsVM = _mapper.Map<List<Sector>, List<TypeVM>>(sectors);

            response.Result.Sectors = sectorsVM;

            response.Status = HttpStatusCode.OK;
            return response;
        }

        [HttpGet("GetCity")]
        [AllowAnonymous]
        public ServiceResult<CityResponseDetails> GetCity([FromQuery] GetCityRequest request)
        {
            var response = new ServiceResult<CityResponseDetails>();

            var cities = _unitOfWork.CityRepository.GetAll()
                .Where(t => t.CountryId == request.CountryId)
                .OrderBy(x => x.Adi)
                .ToList();

            var citiesVM = _mapper.Map<List<City>, List<CityVM>>(cities);

            response.Status = HttpStatusCode.OK;
            response.Result.Cities = citiesVM;

            response.Status = HttpStatusCode.OK;
            return response;
        }

        [HttpGet("GetCounty")]
        [AllowAnonymous]
        public ServiceResult<CountyResponseDetails> GetCounty([FromQuery] GetCountyRequest request)
        {
            var response = new ServiceResult<CountyResponseDetails>();

            var counties = _unitOfWork.CountyRepository.GetAll()
                .Where(t => t.CityId == request.CityId)
                .OrderBy(x => x.Adi)
                .ToList();

            var countiesVM = _mapper.Map<List<County>, List<CountyVM>>(counties);

            response.Status = HttpStatusCode.OK;
            response.Result.Counties = countiesVM;

            response.Status = HttpStatusCode.OK;
            return response;
        }
    }
}