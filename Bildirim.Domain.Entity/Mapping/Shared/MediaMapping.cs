using Bildirim.Domain.Entity.Entities.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bildirim.Domain.Entity.Mapping.Shared
{
    public class MediaMapping : IEntityTypeConfiguration<Media>
    {
        public void Configure(EntityTypeBuilder<Media> builder)
        {
            builder.ToTable("T_MEDIA");

            builder.Property(t => t.FilePath)
               .HasColumnName("FILE_PATH")
               .IsRequired();

            builder.Property(t => t.FileName)
              .HasColumnName("FILE_NAME")
              .IsRequired();

            builder.Property(t => t.Size)
               .HasColumnName("SIZE")
               .IsRequired();

            builder.HasOne(t => t.FileType)
                .WithMany()
                .HasForeignKey(t => t.FileTypeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(t => t.FileTypeId)
                .IsRequired()
                .HasColumnName("FILE_TYPE_ID");
        }
    }
}
