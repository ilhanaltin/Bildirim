using Bildirim.Domain.Entity.Entities.Campaigns;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bildirim.Domain.Mapping.Blog
{
    public class CampaignMapping : IEntityTypeConfiguration<Campaign>
    {        
        public void Configure(EntityTypeBuilder<Campaign> builder)
        {
            builder.ToTable("T_CAMPAIGN");

            builder.HasOne(t => t.Notification)
                .WithMany()
                .HasForeignKey(t => t.NotificationId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(t => t.NotificationId)
                .IsRequired()
                .HasColumnName("NOTIFICATION_ID");

            builder.HasOne(t => t.CampaignType)
                .WithMany()
                .HasForeignKey(t => t.CampaignTypeId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Property(t => t.CampaignTypeId)
                .IsRequired()
                .HasColumnName("CAMPAIGN_TYPE_ID");

            builder.ToTable("T_CAMPAIGN");

            builder.Property(t => t.DetailLink)
               .HasColumnName("DETAIL_LINK");

            builder.Property(t => t.MainImageLink)
               .HasColumnName("MAIN_IMAGE_LINK");

            builder.Property(t => t.LogoLink)
               .HasColumnName("LOGO_LINK");

            builder.Property(t => t.IconLink)
               .HasColumnName("ICON_LINK");

            builder.HasOne(t => t.OwnerBrand)
                .WithMany()
                .HasForeignKey(t => t.OwnerBrandId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Property(t => t.OwnerBrandId)
                .IsRequired()
                .HasColumnName("OWNER_BRAND_ID");

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

            builder.Property(t => t.StartDate)
               .HasColumnName("START_DATE");

            builder.Property(t => t.EndDate)
               .HasColumnName("END_DATE")
               .IsRequired();

            builder.Property(t => t.BonusValidityStartDate)
               .HasColumnName("BONUS_VALIDITY_START_DATE");

            builder.Property(t => t.BonusValidityEndDate)
               .HasColumnName("BONUS_VALIDITY_END_DATE");

            builder.Property(t => t.DetailText)
               .HasColumnName("DETAIL_TEXT")
               .IsRequired();

           
        }
    }
}