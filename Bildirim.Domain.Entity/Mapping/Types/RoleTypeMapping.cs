using Bildirim.Domain.Entity.Entities.Types;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bildirim.Domain.Entity.Mapping.Types
{
    class RoleTypeMapping : IEntityTypeConfiguration<RoleType>
    {
        public void Configure(EntityTypeBuilder<RoleType> builder)
        {
            builder.ToTable("TT_ROLE");

            builder.Property(ak => ak.Adi)
                .HasColumnName("ADI")
                .IsRequired();
        }
    }
}
