
using Bildirim.App.Migrations;
using Bildirim.Domain.Entity.Entities.Shared;
using Bildirim.Infrastructure.Main.Repositories.Interfaces.Shared;

namespace Bildirim.Infrastructure.Main.Repositories.Impl.Shared
{
    public class SectorRepository : BaseRepository<Sector>, ISectorRepository
    {
        public SectorRepository(BildirimContext context) : base(context)
        {

        }
    }
}
