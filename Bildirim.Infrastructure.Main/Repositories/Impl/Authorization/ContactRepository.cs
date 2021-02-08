using Bildirim.App.Migrations;
using Bildirim.Domain.Entity.Entities.Authorization;
using Bildirim.Infrastructure.Main.Repositories.Interfaces.Authorization;

namespace Bildirim.Infrastructure.Main.Repositories.Impl.Authorization
{
    public class ContactRepository : BaseRepository<Contact>, IContactRepository
    {
        public ContactRepository(BildirimContext context) : base(context)
        {

        }
    }
}
