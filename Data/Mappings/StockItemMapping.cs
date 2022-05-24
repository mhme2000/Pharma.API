using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pharma.API.Model;

namespace Pharma.API.Data.Mappings
{
    public class StockItemMapping : IEntityTypeConfiguration<StockItemModel>
    {
        public void Configure(EntityTypeBuilder<StockItemModel> builder)
        {
            builder.ToTable("StockItem");

            builder.HasKey(c => c.StockItemId);
            builder.Property(c => c.StockItemId).ValueGeneratedOnAdd();
            builder.HasMany(x => x.StockTransactionItems).WithOne(b => b.StockItem).HasForeignKey(b => b.StockItemId)
           .OnDelete(DeleteBehavior.Cascade);

        }
    }

}