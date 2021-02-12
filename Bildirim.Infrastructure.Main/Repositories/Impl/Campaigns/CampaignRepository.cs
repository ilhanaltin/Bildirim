
using Bildirim.App.Migrations;
using Bildirim.Domain.Entity.Entities.Campaigns;
using Bildirim.Infrastructure.Main.Repositories.Interfaces.Notify;

namespace Bildirim.Infrastructure.Main.Repositories.Impl.Types
{
    public class CampaignRepository : BaseRepository<Campaign>, ICampaignRepository
    {
        public CampaignRepository(BildirimContext context) : base(context)
        {

        }
    }
}
