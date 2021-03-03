
using Bildirim.App.Migrations;
using Bildirim.Domain.Entity.Entities.Shared;
using Bildirim.Infrastructure.Main.Repositories.Interfaces.Shared;

namespace Bildirim.Infrastructure.Main.Repositories.Impl.Shared
{
    public class CityRepository : BaseRepository<City>, ICityRepository
    {
        public CityRepository(BildirimContext context) : base(context)
        {

        }
    }
}
