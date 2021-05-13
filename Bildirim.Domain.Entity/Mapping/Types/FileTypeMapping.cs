using Bildirim.Domain.Entity.Entities.Types;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bildirim.Domain.Entity.Mapping.Types
{
    class FileTypeMapping : IEntityTypeConfiguration<FileType>
    {
        public void Configure(EntityTypeBuilder<FileType> builder)
        {
            builder.ToTable("TT_FILE");

            builder.Property(ak => ak.Adi)
                .HasColumnName("ADI")
                .IsRequired();
        }
    }
}
