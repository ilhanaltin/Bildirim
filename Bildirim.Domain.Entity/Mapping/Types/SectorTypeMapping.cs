using Bildirim.Domain.Entity.Entities.Types;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bildirim.Domain.Entity.Mapping.Types
{
    class SectorTypeMapping : IEntityTypeConfiguration<SectorType>
    {
        public void Configure(EntityTypeBuilder<SectorType> builder)
        {
            builder.ToTable("TT_SECTOR");

            builder.Property(ak => ak.Adi)
                .HasColumnName("ADI")
                .IsRequired();
        }
    }
}
