using Bildirim.Domain.Entity.Entities.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bildirim.Domain.Entity.Mapping.Authorization
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("T_USER");            

            builder.Property(t => t.Name)
                .HasColumnName("NAME")
                .IsRequired();

            builder.Property(t => t.LastName)
                .HasColumnName("LASTNAME")
                .IsRequired();

            builder.Property(t => t.NickName)
                .HasColumnName("NICKNAME")
                .IsRequired(false);

            builder.Property(t => t.Password)
                .HasColumnName("PASSWORD")
                .IsRequired();

            builder.Property(t => t.Email)
                .HasColumnName("EMAIL")
                .IsRequired();

            builder.HasOne(t => t.UserLoginType)
                .WithMany()
                .HasForeignKey(t => t.UserLoginTypeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(t => t.UserLoginTypeId)
                .IsRequired()
                .HasDefaultValueSql("1")
                .HasColumnName("USER_LOGIN_TYPE_ID");

            builder.Property(t => t.SocialMediaUserId)
               .HasColumnName("SOCIAL_MEDIA_USER_ID")
               .IsRequired(false);

            builder.HasOne(t => t.UserStatusType)
                .WithMany()
                .HasForeignKey(t => t.UserStatusTypeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(t => t.UserStatusTypeId)
                .IsRequired()
                .HasColumnName("USER_STATUS_TYPE_ID");

            builder.Property(t => t.IsBlocked)
                .HasColumnName("IS_BLOCKED")
                .IsRequired();
        }
    }
}
