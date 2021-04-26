using Bildirim.Domain.Entity.Entities.Campaigns;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bildirim.Domain.Mapping.Blog
{
    public class UserFavoriteCategoriesMapping : IEntityTypeConfiguration<UserFavoriteCategories>
    {        
        public void Configure(EntityTypeBuilder<UserFavoriteCategories> builder)
        {
            builder.ToTable("T_USER_FAVORITE_CATEGORIES");

            builder.HasOne(t => t.User)
                .WithMany(t => t.UserFavoriteCategories)
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("USER_ID");

            builder.HasOne(t => t.Brand)
                .WithMany()
                .HasForeignKey(t => t.BrandId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Property(t => t.BrandId)
                .HasColumnName("BRAND_ID");

            builder.HasOne(t => t.Sector)
              .WithMany()
              .HasForeignKey(t => t.SectorId)
              .OnDelete(DeleteBehavior.NoAction);

            builder.Property(t => t.SectorId)
                .HasColumnName("SECTOR_ID");
        }
    }
}