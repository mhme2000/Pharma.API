using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pharma.API.Model;

namespace Pharma.API.Data.Mappings
{
    public class StockMapping : IEntityTypeConfiguration<StockModel>
    {
        public void Configure(EntityTypeBuilder<StockModel> builder)
        {
            builder.ToTable("Stock");

            builder.HasKey(c => c.StockId);
            builder.Property(c => c.StockId).ValueGeneratedOnAdd();
            builder.HasMany(x => x.StockItems).WithOne(b => b.Stock).HasForeignKey(b => b.StockId)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }

}