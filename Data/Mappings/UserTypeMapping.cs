using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pharma.API.Model;

namespace Pharma.API.Data.Mappings
{
    public class UserTypeMapping : IEntityTypeConfiguration<UserTypeModel>
    {
        public void Configure(EntityTypeBuilder<UserTypeModel> builder)
        {
            builder.ToTable("UserType");
            builder.HasKey(x => x.UserTypeId);
            builder.Property(x => x.Description).HasColumnType("text");
            builder.HasMany(x => x.Users).WithOne(b => b.UserType).HasForeignKey(b => b.UserTypeId)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }

}