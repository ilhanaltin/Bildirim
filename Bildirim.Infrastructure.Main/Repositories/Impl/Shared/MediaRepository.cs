using Bildirim.App.Migrations;
using Bildirim.Domain.Entity.Entities.Shared;
using Bildirim.Infrastructure.Main.Repositories.Interfaces.Shared;

namespace Bildirim.Infrastructure.Main.Repositories.Impl.Shared
{
    public class MediaRepository : BaseRepository<Media>, IMediaRepository
    {
        public MediaRepository(BildirimContext context) : base(context)
        {

        }
    }
}