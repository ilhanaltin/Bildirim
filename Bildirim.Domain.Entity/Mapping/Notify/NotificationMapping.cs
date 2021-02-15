using Bildirim.Domain.Entity.Entities.Notify;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bildirim.Domain.Mapping.Blog
{
    public class NotificationMapping : IEntityTypeConfiguration<Notification>
    {        
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.ToTable("T_NOTIFICATION");

            builder.Property(t => t.Name)
               .HasColumnName("NAME");

            builder.HasOne(t => t.NotificationType)
                .WithMany()
                .HasForeignKey(t => t.NotificationTypeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(t => t.NotificationTypeId)
                .IsRequired()
                .HasColumnName("NOTIFICATION_TYPE_ID");

            builder.HasOne(t => t.NotificationStatusType)
                .WithMany()
                .HasForeignKey(t => t.NotificationStatusTypeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(t => t.NotificationStatusTypeId)
                .IsRequired()
                .HasColumnName("NOTIFICATION_STATUS_TYPE_ID");

            builder.Property(t => t.ReadCount)
              .HasColumnName("READ_COUNT");

            builder.HasOne(t => t.County)
                .WithMany()
                .HasForeignKey(t => t.CountyId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Property(t => t.CountyId)
                .HasColumnName("COUNTY_ID");

            builder.HasOne(t => t.City)
                .WithMany()
                .HasForeignKey(t => t.CityId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Property(t => t.CityId)
                .HasColumnName("CITY_ID");

            builder.HasOne(t => t.Country)
               .WithMany()
               .HasForeignKey(t => t.CountryId)
               .OnDelete(DeleteBehavior.NoAction);

            builder.Property(t => t.CountryId)
                .IsRequired()
                .HasColumnName("COUNTRY_ID");
        }
    }
}