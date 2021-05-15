using AutoMapper;
using Bildirim.Common;
using Bildirim.Common.Types;
using Bildirim.Domain.Entity.Entities.Authorization;
using Bildirim.Domain.Entity.Entities.Campaigns;
using Bildirim.Domain.Entity.Entities.Notify;
using Bildirim.Domain.Entity.Entities.Shared;
using Bildirim.Domain.Model.ReqRes;

namespace Bildirim.Presentation.Api.Mappings
{
    public class DTOToDomain : Profile
    {
        public DTOToDomain()
        {
            ConfigureUserMappings();
            ConfigureCampaignMappings();
            ConfigureNotificationMappings();
            ConfigureTypesMappings();
        }

        public void ConfigureUserMappings()
        {
            CreateMap<RegisterRequest, User>()
                .ForMember(x => x.UserStatusTypeId, opt => opt.MapFrom(t => Constants.USER_STATUS_WAITING_ACTIVATION))
                .ForMember(x => x.UserRoles, opt => opt.Ignore());
        }

        public void ConfigureCampaignMappings()
        {
            CreateMap<CampaignPostRequest, Campaign>()
                .ForMember(x => x.Id, opt => opt.Ignore());

            CreateMap<UpdateUserFavoritesRequest, UserFavoriteCategories>()
                .ForMember(x => x.Id, opt => opt.Ignore());
        }

        public void ConfigureNotificationMappings()
        {
            CreateMap<CampaignPostRequest, Notification>()
                .ForMember(x => x.Id, opt => opt.Ignore());
        }

        public void ConfigureTypesMappings()
        {
            CreateMap<SaveUpdateSectorRequest, Sector>()
                .ForMember(x => x.Id, opt => opt.Ignore())
                .ForMember(x => x.CountryId, opt => opt.Ignore());

            CreateMap<SaveUpdateBrandRequest, Brand>()
               .ForMember(x => x.Id, opt => opt.Ignore())
               .ForMember(x => x.CountryId, opt => opt.Ignore());

        }
    }
}
