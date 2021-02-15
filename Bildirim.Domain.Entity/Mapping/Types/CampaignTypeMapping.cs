using Bildirim.Domain.Entity.Entities.Types;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bildirim.Domain.Entity.Mapping.Types
{
    class CampaignTypeMapping : IEntityTypeConfiguration<CampaignType>
    {
        public void Configure(EntityTypeBuilder<CampaignType> builder)
        {
            builder.ToTable("TT_CAMPAIGN");

            builder.Property(ak => ak.Adi)
                .HasColumnName("ADI")
                .IsRequired();
        }
    }
}
