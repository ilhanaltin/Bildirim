using Bildirim.Domain.Entities.Entity;
using Bildirim.Domain.Entity.Entities.Authorization;
using Bildirim.Domain.Entity.Entities.Shared;

namespace Bildirim.Domain.Entity.Entities.Campaigns
{
    public class UserFavoriteCategories : BaseEntity
    {
        public long UserId { get; set; }

        public virtual User User { get; set; }

        public long SectorId { get; set; }

        public virtual Sector Sector { get; set; }

        public long BrandId { get; set; }

        public virtual Brand Brand { get; set; }
    }
}