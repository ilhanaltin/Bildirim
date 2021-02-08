using Bildirim.Domain.Entity.Entities.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bildirim.Domain.Entity.Mapping.Shared
{
    public class CityMapping : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("TT_CITY");

            builder.Property(t => t.Adi)
              .IsRequired()
              .HasColumnName("ADI");

            builder.HasOne(t => t.Country)
               .WithMany()
               .HasForeignKey(t => t.CountryId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.Property(t => t.CountryId)
                .IsRequired()
                .HasColumnName("COUNTRY_ID");
        }
    }
}
