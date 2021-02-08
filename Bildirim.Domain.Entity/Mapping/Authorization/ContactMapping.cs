using Bildirim.Domain.Entity.Entities.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bildirim.Domain.Entity.Mapping.Authorization
{
    public class ContactMapping : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("T_CONTACT");

            builder.HasOne(t => t.User)
               .WithMany()
               .HasForeignKey(t => t.UserId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.Property(t => t.UserId)
                .IsRequired(false)
                .HasColumnName("USER_ID");

            builder.Property(t => t.NameSurname)
               .HasColumnName("NAME_SURNAME")
               .IsRequired(false);

            builder.Property(t => t.Email)
              .HasColumnName("EMAIL")
              .IsRequired(false);

            builder.Property(t => t.Gsm)
              .HasColumnName("GSM")
              .IsRequired(false);

            builder.Property(t => t.Message)
             .HasColumnName("MESSAGE")
             .IsRequired();
        }
    }
}
