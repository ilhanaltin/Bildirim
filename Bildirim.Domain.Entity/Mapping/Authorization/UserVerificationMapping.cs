using Bildirim.Domain.Entity.Entities.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bildirim.Domain.Entity.Mapping.Authorization
{
    public class UserVerificationapping : IEntityTypeConfiguration<UserVerification>
    {
        public void Configure(EntityTypeBuilder<UserVerification> builder)
        {
            builder.ToTable("T_USER_VERIFICATION");

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("USER_ID");

            builder.Property(t => t.Token)
                .IsRequired()
                .HasColumnName("TOKEN");

            builder.Property(t => t.Active)
                .IsRequired()
                .HasDefaultValueSql("1")
                .HasColumnName("ACTIVE");
        }
    }
}
