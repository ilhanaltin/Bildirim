using Bildirim.Domain.Entity.Entities.Types;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bildirim.Domain.Entity.Mapping.Types
{
    public class UserStatusTypeMapping : IEntityTypeConfiguration<UserStatusType>
    {
        public void Configure(EntityTypeBuilder<UserStatusType> builder)
        {
            builder.ToTable("TT_USER_STATUS");

            builder.Property(ak => ak.Adi)
                .HasColumnName("ADI")
                .IsRequired();
        }
    }
}
