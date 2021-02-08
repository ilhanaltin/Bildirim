using Bildirim.App.Migrations;
using Bildirim.Domain.Entity.Entities.Types;
using Bildirim.Infrastructure.Main.Repositories.Interfaces.Types;

namespace Bildirim.Infrastructure.Main.Repositories.Impl.Types
{
    public class NotificationTypeRepository : BaseRepository<NotificationType>, INotificationTypeRepository
    {
        public NotificationTypeRepository(BildirimContext context) : base(context)
        {

        }
    }
}
