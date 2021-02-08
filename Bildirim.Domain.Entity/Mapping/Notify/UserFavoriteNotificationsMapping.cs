using Bildirim.Domain.Entity.Entities.Notify;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bildirim.Domain.Entity.Mapping.Notify
{
    public class UserFavoriteNotificationsMapping : IEntityTypeConfiguration<UserFavoriteNotifications>
    {
        public void Configure(EntityTypeBuilder<UserFavoriteNotifications> builder)
        {
            builder.ToTable("T_USER_FAVORITE_NOTIFICATIONS");

            builder.HasOne(t => t.User)
                .WithMany(t => t.UserFavoriteNotifications)
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("USER_ID");

            builder.HasOne(t => t.NotificationType)
                .WithMany()
                .HasForeignKey(t => t.NotificationTypeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(t => t.NotificationTypeId)
                .IsRequired()
                .HasColumnName("NOTIFICATION_TYPE_ID");
        }
    }
}
