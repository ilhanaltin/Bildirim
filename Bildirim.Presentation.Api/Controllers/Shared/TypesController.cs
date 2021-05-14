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
        public ServiceResult<BrandListResponseDetails> GetBrands([FromQuery] GetBrandRequest request)
        {
            var response = new ServiceResult<BrandListResponseDetails>();

            var brands = _unitOfWork.BrandRepository.GetAll()
                .Where(t => t.CountryId == request.CountryId)
                .OrderBy(x => x.Adi)
                .ToList();

            var brandsVM = _mapper.Map<List<Brand>, List<BrandVM>>(brands);

            response.Result.Brands = brandsVM;

            response.Status = HttpStatusCode.OK;
            return response;
        }

        [HttpGet("GetBrandsForAdmin")]
        [AllowAnonymous]
        public ServiceResult<BrandListResponseDetails> GetBrandsForAdmin([FromQuery] GetBrandForAdminRequest request)
        {
            var response = new ServiceResult<BrandListResponseDetails>();

            var brands = _unitOfWork.BrandRepository.GetAll()
                .Where(t => t.CountryId == request.CountryId)
                .OrderBy(x => x.Adi)
                .ToList();

            var campaignCountGroupBy = _unitOfWork.CampaignRepository.GetAll()
                  .GroupBy(m => m.BrandId)
                  .Select(m => new { BrandId = m.Key, CampaignCount = m.Count() })
                  .ToList();

            var brandsVM = _mapper.Map<List<Brand>, List<BrandVM>>(brands);

            foreach (var _brandVM in brandsVM)
            {
                var campCount = campaignCountGroupBy.Where(t => t.BrandId == _brandVM.Id).FirstOrDefault();

                _brandVM.CampaignCount = 0;
                if (campCount != null)
                    _brandVM.CampaignCount = campCount.CampaignCount;
            }

            response.Result.Brands = brandsVM;
            response.Status = HttpStatusCode.OK;
            return response;
        }

        [HttpPost("UpdateBrand")]
        public ServiceResult<StandartResponseDetails> UpdateSector([FromBody] SaveUpdateBrandRequest request)
        {
            var response = new ServiceResult<StandartResponseDetails>();
            var brand = new Brand();

            if (request.Id.HasValue)
            {
                brand = _unitOfWork.BrandRepository.Get(t => t.Id == request.Id);
            }

            _mapper.Map<SaveUpdateBrandRequest, Brand>(request, brand);

            if (request.Id > 0)
            {
                _unitOfWork.BrandRepository.Update(brand);
            }
            else
            {
                _unitOfWork.BrandRepository.Add(brand);
            }

            response.Status = HttpStatusCode.OK;
            return response;
        }

        [HttpGet("GetBrandsOfSector")]
        [AllowAnonymous]
        public ServiceResult<BrandListResponseDetails> GetBrandsOfSector([FromQuery] GetBrandRequest request)
        {
            var response = new ServiceResult<BrandListResponseDetails>();

            var brands = _unitOfWork.CampaignRepository.GetAll()
                .Where(t => t.BrandId != null && t.SectorId == request.SectorId)
                .Include(x => x.Brand)
                .Select(column => new Brand
                {
                    Id = column.Brand.Id,
                    Adi = column.Brand.Adi
                })
                .Distinct()
                .OrderBy(x => x.Adi)
                .ToList();

            var brandsVM = _mapper.Map<List<Brand>, List<BrandVM>>(brands);

            if (request.UserId.HasValue && request.UserId.Value > 0)
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
        public ServiceResult<SectorListResponseDetails> GetSectors([FromQuery] GetSectorRequest request)
        {
            var response = new ServiceResult<SectorListResponseDetails>();

            var sectors = _unitOfWork.SectorRepository.GetAll()
                .Where(t => t.CountryId == request.CountryId)
                .OrderBy(x => x.Adi)
                .ToList();

            var sectorsVM = _mapper.Map<List<Sector>, List<SectorVM>>(sectors);

            response.Result.Sectors = sectorsVM;

            response.Status = HttpStatusCode.OK;
            return response;
        }

        [HttpGet("GetSectorsForAdmin")]
        [AllowAnonymous]
        public ServiceResult<SectorListResponseDetails> GetSectorsForAdmin([FromQuery] GetSectorRequest request)
        {
            var response = new ServiceResult<SectorListResponseDetails>();

            var sectors = _unitOfWork.SectorRepository.GetAll()
                .Where(t => t.CountryId == request.CountryId)
                .OrderBy(x => x.Adi)
                .ToList();

            var campaignCountGroupBy = _unitOfWork.CampaignRepository.GetAll()
                  .GroupBy(m => m.SectorId)
                  .Select(m => new { SectorId = m.Key, CampaignCount = m.Count() })
                  .ToList();

            var sectorsVM = _mapper.Map<List<Sector>, List<SectorVM>>(sectors);

            foreach (var _sectorVM in sectorsVM)
            {
                var campCount = campaignCountGroupBy.Where(t => t.SectorId == _sectorVM.Id).FirstOrDefault();

                _sectorVM.CampaignCount = 0;
                if (campCount != null)
                    _sectorVM.CampaignCount = campCount.CampaignCount;
            }

            response.Result.Sectors = sectorsVM;
            response.Status = HttpStatusCode.OK;
            return response;
        }

        [HttpGet("GetFavoriteSectors")]
        [AllowAnonymous]
        public ServiceResult<SectorListResponseDetails> GetFavoriteSectors([FromQuery] GetSectorRequest request)
        {
            var response = new ServiceResult<SectorListResponseDetails>();

            var sectors = _unitOfWork.SectorRepository.GetAll()
                .Where(t => t.CountryId == request.CountryId)
                .OrderBy(x => x.Adi)
                .Take(10)
                .ToList();

            var sectorsVM = _mapper.Map<List<Sector>, List<SectorVM>>(sectors);

            response.Result.Sectors = sectorsVM;

            response.Status = HttpStatusCode.OK;
            return response;
        }

        [HttpPost("UpdateSector")]
        public ServiceResult<StandartResponseDetails> UpdateSector([FromBody] SaveUpdateSectorRequest request)
        {
            var response = new ServiceResult<StandartResponseDetails>();
            var sector = new Sector();

            if(request.Id.HasValue)
            {
                sector = _unitOfWork.SectorRepository.Get(t => t.Id == request.Id);
            }
                
            _mapper.Map<SaveUpdateSectorRequest, Sector>(request, sector);

            if (request.Id > 0)
            {
                _unitOfWork.SectorRepository.Update(sector);
            }
            else
            {
                _unitOfWork.SectorRepository.Add(sector);
            }

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