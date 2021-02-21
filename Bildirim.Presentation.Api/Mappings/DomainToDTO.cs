using Bildirim.Domain.Entity.Entities.Types;
using Bildirim.Domain.Model.Types;
using AutoMapper;
using Bildirim.Domain.Entity.Entities.Authorization;
using Bildirim.Domain.Model.Authorization;
using Bildirim.Domain.Entity.Entities.Notify;
using Bildirim.Domain.Model.Notify;
using Bildirim.Domain.Entity.Entities.Campaigns;
using Bildirim.Domain.Model.Campaigns;
using System.Collections.Generic;

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
        }

        public void ConfigureTypeMappings()
        {
            CreateMap<RoleType, TypeVM>();
            CreateMap<UserStatusType, TypeVM>();
        }

        public void ConfigureNotificationMappings()
        {
            CreateMap<Notification, NotificationVM>();

            CreateMap<NotificationVote, NotificationVoteVM>();
        }

        public void ConfigureCampaignMappings()
        {
            CreateMap<Campaign, CampaignVM>()
                .ForMember(x => x.NotificationVM, opt => opt.MapFrom(t => t.Notification));
        }

        public void ConfigureUserMappings()
        {
            CreateMap<User, UserVM>()
                .ForMember(x => x.StatusId, opt => opt.MapFrom(t => t.UserStatusTypeId))
                .ForMember(x => x.StatusName, opt => opt.MapFrom(t => t.UserStatusType.Adi))
                .ForMember(x => x.RoleId, opt => opt.MapFrom(t => t.UserRoles[0].RoleTypeId))
                .ForMember(x => x.RoleName, opt => opt.MapFrom(t => t.UserRoles[0].RoleType.Adi));
        }
    }
}
