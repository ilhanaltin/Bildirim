using Bildirim.Domain.Entity.Entities.Campaigns;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bildirim.Domain.Mapping.Blog
{
    public class CampaignMapping : IEntityTypeConfiguration<Campaign>
    {        
        public void Configure(EntityTypeBuilder<Campaign> builder)
        {
            builder.HasOne(t => t.Notification)
                .WithMany()
                .HasForeignKey(t => t.NotificationId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(t => t.NotificationId)
                .IsRequired()
                .HasColumnName("NOTIFICATION_ID");

            builder.ToTable("T_CAMPAIGN");

            builder.Property(t => t.DetailLink)
               .HasColumnName("DETAIL_LINK");

            builder.Property(t => t.MainImageLink)
               .HasColumnName("MAIN_IMAGE_LINK");

            builder.Property(t => t.LogoLink)
               .HasColumnName("LOGO_LINK");

            builder.Property(t => t.IconLink)
               .HasColumnName("ICON_LINK");

            builder.HasOne(t => t.Company)
                .WithMany()
                .HasForeignKey(t => t.CompanyId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Property(t => t.CompanyId)
                .IsRequired()
                .HasColumnName("COMPANY_ID");

            builder.HasOne(t => t.Brand)
                .WithMany()
                .HasForeignKey(t => t.BrandId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Property(t => t.BrandId)
                .IsRequired()
                .HasColumnName("BRAND_ID");

            builder.HasOne(t => t.SectorType)
              .WithMany()
              .HasForeignKey(t => t.SectorTypeId)
              .OnDelete(DeleteBehavior.NoAction);

            builder.Property(t => t.SectorTypeId)
                .IsRequired()
                .HasColumnName("SECTOR_TYPE_ID");

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