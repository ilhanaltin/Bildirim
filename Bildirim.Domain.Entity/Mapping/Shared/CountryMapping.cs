using Bildirim.Domain.Entity.Entities.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bildirim.Domain.Entity.Mapping.Shared
{
    public class CountryMapping : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("TT_COUNTRY");

            builder.Property(t => t.Adi)
              .IsRequired()
              .HasColumnName("ADI");
        }
    }
}
