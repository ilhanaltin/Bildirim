using Bildirim.Domain.Entity.Entities.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bildirim.Domain.Entity.Mapping.Shared
{
    public class CompanyMapping : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("TT_COMPANY");

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
        }
    }
}
