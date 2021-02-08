using Bildirim.Domain.Entity.Entities.Types;
using Bildirim.Domain.Model.Types;
using AutoMapper;
using Bildirim.Domain.Entity.Entities.Authorization;
using Bildirim.Domain.Model.Authorization;
using Bildirim.Domain.Entity.Entities.Notify;
using Bildirim.Domain.Model.Notify;

namespace Bildirim.Presentation.Api.Mappings
{
    public class DomainToDTO : Profile
    {
        public DomainToDTO()
        {
            ConfigureTypeMappings();
            ConfigureUserMappings();
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

        public void ConfigureUserMappings()
        {
            CreateMap<User, UserVM>()
                .ForMember(x => x.StatusId, opt => opt.MapFrom(t => t.UserStatusTypeId))
                .ForMember(x => x.StatusName, opt => opt.MapFrom(t => t.UserStatusType.Adi))
                .ForMember(x => x.RoleId, opt => opt.MapFrom(t => t.UserRoles[0].RoleTypeId))
                .ForMember(x => x.RoleName, opt => opt.MapFrom(t => t.UserRoles[0].RoleType.Adi));

            CreateMap<Contact, ContactVM>();
        }
    }
}
