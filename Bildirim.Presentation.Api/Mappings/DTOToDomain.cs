using AutoMapper;
using Bildirim.Common;
using Bildirim.Common.Types;
using Bildirim.Domain.Entity.Entities.Authorization;
using Bildirim.Domain.Model.ReqRes;

namespace Bildirim.Presentation.Api.Mappings
{
    public class DTOToDomain : Profile
    {
        public DTOToDomain()
        {
            ConfigureUserMappings();
        }

        public void ConfigureUserMappings()
        {
            CreateMap<RegisterRequest, User>()
                .ForMember(x => x.UserStatusTypeId, opt => opt.MapFrom(t => Constants.USER_STATUS_WAITING_ACTIVATION))
                .ForMember(x => x.UserRoles, opt => opt.Ignore());

            CreateMap<ContactRequest, Contact>();
        }
    }
}
