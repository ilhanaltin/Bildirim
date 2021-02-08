using Bildirim.Domain.Entity.Entities.Notify;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bildirim.Domain.Mapping.Blog
{
    public class NotificationVotesMapping : IEntityTypeConfiguration<NotificationVote>
    {        
        public void Configure(EntityTypeBuilder<NotificationVote> builder)
        {
            builder.ToTable("T_NOTIFICATION_VOTE");

            builder.HasOne(t => t.User)
                .WithMany()
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("USER_ID");

            builder.HasOne(t => t.Notification)
                .WithMany(t => t.NotificationVotes)
                .HasForeignKey(t => t.NotificationId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(t => t.NotificationId)
                .IsRequired()
                .HasColumnName("NOTIFICATION_ID");
        }
    }
}