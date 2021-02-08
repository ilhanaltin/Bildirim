using Bildirim.Domain.Entity.Entities.Types;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bildirim.Domain.Entity.Mapping.Types
{
    class NotificationStatusTypeMapping : IEntityTypeConfiguration<NotificationStatusType>
    {
        public void Configure(EntityTypeBuilder<NotificationStatusType> builder)
        {
            builder.ToTable("TT_NOTIFICATION_STATUS");

            builder.Property(ak => ak.Adi)
                .HasColumnName("ADI")
                .IsRequired();
        }
    }
}
