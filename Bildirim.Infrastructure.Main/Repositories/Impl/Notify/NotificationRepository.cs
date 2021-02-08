using Bildirim.App.Migrations;
using Bildirim.Domain.Entity.Entities.Notify;
using Bildirim.Infrastructure.Main.Repositories.Interfaces.Notify;

namespace Bildirim.Infrastructure.Main.Repositories.Impl.Types
{
    public class NotificationRepository : BaseRepository<Notification>, INotificationRepository
    {
        public NotificationRepository(BildirimContext context) : base(context)
        {

        }
    }
}
