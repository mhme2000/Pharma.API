using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pharma.API.Model;

namespace Pharma.API.Data.Mappings
{
    public class UserMapping : IEntityTypeConfiguration<UserModel>
    {
        public void Configure(EntityTypeBuilder<UserModel> builder)
        {
            builder.ToTable("User");

            builder.HasKey(c => c.UserId);
            builder.Property(c => c.UserId).ValueGeneratedOnAdd();
            builder.HasMany(x => x.StockTransactions).WithOne(b => b.User).HasForeignKey(b => b.UserId)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }

}