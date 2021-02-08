using Bildirim.App.Migrations;
using Bildirim.Domain.Entity.Entities.Types;
using Bildirim.Infrastructure.Main.Repositories.Interfaces.Types;

namespace Bildirim.Infrastructure.Main.Repositories.Impl.Types
{
    public class UserStatusTypeRepository : BaseRepository<UserStatusType>, IUserStatusTypeRepository
    {
        public UserStatusTypeRepository(BildirimContext context) : base(context)
        {

        }
    }
}
