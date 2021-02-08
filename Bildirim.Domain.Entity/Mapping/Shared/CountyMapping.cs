using Bildirim.Domain.Entity.Entities.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bildirim.Domain.Entity.Mapping.Shared
{
    public class CountyMapping : IEntityTypeConfiguration<County>
    {
        public void Configure(EntityTypeBuilder<County> builder)
        {
            builder.ToTable("TT_COUNTY");

            builder.Property(t => t.Adi)
               .IsRequired()
               .HasColumnName("ADI");

            builder.HasOne(t => t.City)
               .WithMany()
               .HasForeignKey(t => t.CityId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.Property(t => t.CityId)
                .IsRequired()
                .HasColumnName("CITY_ID");
        }
    }
}

