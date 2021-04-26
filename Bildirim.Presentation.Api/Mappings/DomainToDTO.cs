using Bildirim.Domain.Entity.Entities.Types;
using Bildirim.Domain.Model.Types;
using AutoMapper;
using Bildirim.Domain.Entity.Entities.Authorization;
using Bildirim.Domain.Model.Authorization;
using Bildirim.Domain.Entity.Entities.Notify;
using Bildirim.Domain.Model.Notify;
using Bildirim.Domain.Entity.Entities.Campaigns;
using Bildirim.Domain.Model.Campaigns;
using Bildirim.Domain.Entity.Entities.Shared;
using Bildirim.Domain.Model.Shared;
using Bildirim.Common.Helpers;
using Bildirim.Common;

namespace Bildirim.Presentation.Api.Mappings
{
    public class DomainToDTO : Profile
    {
        public DomainToDTO()
        {
            ConfigureTypeMappings();
            ConfigureUserMappings();
            ConfigureCampaignMappings();
            ConfigureNotificationMappings();
            ConfigureSharedMappings();
        }

        public void ConfigureTypeMappings()
        {
            CreateMap<RoleType, TypeVM>();
            CreateMap<UserStatusType, TypeVM>();
            CreateMap<Brand, BrandVM>();
            CreateMap<Sector, TypeVM>();
            CreateMap<City, CityVM>();
            CreateMap<County, CountyVM>();
        }

        public void ConfigureNotificationMappings()
        {
            CreateMap<Notification, NotificationVM>()
                .ForMember(x => x.CityAdi, opt => opt.MapFrom(t => t.City.Adi))
                .ForMember(x => x.CountryAdi, opt => opt.MapFrom(t => t.Country.Adi))
                .ForMember(x => x.CountyAdi, opt => opt.MapFrom(t => t.County.Adi))
                .ForMember(x => x.NotificationStatusTypeAdi, opt => opt.MapFrom(t => t.NotificationStatusType.Adi))
                .ForMember(x => x.NotificationTypeName, opt => opt.MapFrom(t => t.NotificationType.Adi));

            CreateMap<NotificationVote, NotificationVoteVM>();
        }

        public void ConfigureCampaignMappings()
        {
            CreateMap<Campaign, CampaignVM>()
                .ForMember(x => x.BrandAdi, opt => opt.MapFrom(t => t.Brand.Adi))
                .ForMember(x => x.OwnerBrandAdi, opt => opt.MapFrom(t => t.OwnerBrand.Adi))
                .ForMember(x => x.SectorAdi, opt => opt.MapFrom(t => t.Sector.Adi))
                .ForMember(x => x.CampaignTypeAdi, opt => opt.MapFrom(t => t.CampaignType.Adi));
        }

        public void ConfigureUserMappings()
        {
            CreateMap<User, UserVM>()
                .ForMember(x => x.StatusId, opt => opt.MapFrom(t => t.UserStatusTypeId))
                .ForMember(x => x.StatusName, opt => opt.MapFrom(t => t.UserStatusType.Adi))
                .ForMember(x => x.RoleId, opt => opt.MapFrom(t => t.UserRoles[0].RoleTypeId))
                .ForMember(x => x.RoleName, opt => opt.MapFrom(t => t.UserRoles[0].RoleType.Adi));
        }

        public void ConfigureSharedMappings()
        {
            CreateMap<Media, MediaVM>()
                .ForMember(x => x.Date, opt => opt.MapFrom(t => t.CreatedDateTime))
                .ForMember(x => x.Size, opt => opt.MapFrom(t => FileHelper.GetFileSize(t.Size)))
                .ForMember(x => x.FilePath, opt => opt.MapFrom(t => Constants.ApiUrlAddress + t.FilePath))
                .ForMember(x => x.FileTypeName, opt => opt.MapFrom(t => t.FileType.Adi));
        }
    }
}