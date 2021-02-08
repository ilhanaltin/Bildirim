using Bildirim.Domain.Entity.Entities.Types;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bildirim.Domain.Entity.Mapping.Types
{
    class NotificationTypeMapping : IEntityTypeConfiguration<NotificationType>
    {
        public void Configure(EntityTypeBuilder<NotificationType> builder)
        {
            builder.ToTable("TT_NOTIFICATION");

            builder.Property(ak => ak.Adi)
                .HasColumnName("ADI")
                .IsRequired();

            builder.Property(t => t.ParentId)
               .HasColumnName("PARENT_ID");
        }
    }
}
