using Bildirim.Domain.Entity.Entities.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bildirim.Domain.Entity.Mapping.Shared
{
    public class SectorMapping : IEntityTypeConfiguration<Sector>
    {
        public void Configure(EntityTypeBuilder<Sector> builder)
        {
            builder.ToTable("TT_SECTOR");

            builder.Property(t => t.Adi)
              .IsRequired()
              .HasColumnName("ADI");

            builder.HasOne(t => t.Country)
               .WithMany()
               .HasForeignKey(t => t.CountryId)
               .OnDelete(DeleteBehavior.NoAction);

            builder.Property(t => t.CountryId)
                .IsRequired()
                .HasColumnName("COUNTRY_ID");

            builder.Property(t => t.KisaAdi)
             .HasColumnName("KISA_ADI");

            builder.Property(t => t.Image)
             .HasColumnName("IMAGE");
        }
    }
}
