using Bildirim.Domain.Entity.Entities.Types;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bildirim.Domain.Entity.Mapping.Types
{
    public class UserLoginTypeMapping : IEntityTypeConfiguration<UserLoginType>
    {
        public void Configure(EntityTypeBuilder<UserLoginType> builder)
        {
            builder.ToTable("TT_LOGIN");

            builder.Property(ak => ak.Adi)
                .HasColumnName("ADI")
                .IsRequired();
        }
    }
}
