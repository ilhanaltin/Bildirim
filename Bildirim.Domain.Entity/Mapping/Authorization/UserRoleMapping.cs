using Bildirim.Domain.Entity.Entities.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bildirim.Domain.Entity.Mapping.Authorization
{
    public class UserRoleMapping : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable("T_USER_ROLE");

            builder.HasOne(t => t.User)
                .WithMany(t => t.UserRoles)
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("USER_ID");

            builder.HasOne(t => t.RoleType)
                .WithMany()
                .HasForeignKey(t => t.RoleTypeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(t => t.RoleTypeId)
                .IsRequired()
                .HasColumnName("ROLE_TYPE_ID");
        }
    }
}
