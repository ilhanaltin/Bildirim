using Bildirim.Domain.Entity.Entities.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bildirim.Domain.Entity.Mapping.Authorization
{
    public class LoginMapping : IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> builder)
        {
            builder.ToTable("T_LOGIN");

            builder.HasOne(t => t.User)
               .WithMany()
               .HasForeignKey(t => t.UserId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("USER_ID");

            builder.Property(t => t.SessionId)
               .HasColumnName("SESSION_ID")
               .IsRequired();

            builder.Property(t => t.LoggedIn)
               .HasColumnName("LOGGED_IN")
               .IsRequired();
        }
    }
}
