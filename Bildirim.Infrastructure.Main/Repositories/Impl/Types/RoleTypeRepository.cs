using Bildirim.App.Migrations;
using Bildirim.Domain.Entity.Entities.Types;
using Bildirim.Infrastructure.Main.Repositories.Interfaces.Types;

namespace Bildirim.Infrastructure.Main.Repositories.Impl.Types
{
    public class RoleTypeRepository : BaseRepository<RoleType>, IRoleTypeRepository
    {
        public RoleTypeRepository(BildirimContext context) : base(context)
        {

        }
    }
}
