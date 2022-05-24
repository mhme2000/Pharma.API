using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pharma.API.Model;

namespace Pharma.API.Data.Mappings
{
    public class StockTransactionMapping : IEntityTypeConfiguration<StockTransactionModel>
    {
        public void Configure(EntityTypeBuilder<StockTransactionModel> builder)
        {
            builder.ToTable("StockTransaction");

            builder.HasKey(c => c.StockTransactionId);
            builder.Property(c => c.StockTransactionId).ValueGeneratedOnAdd();
            builder.HasMany(x => x.StockTransactionItems).WithOne(b => b.StockTransaction).HasForeignKey(b => b.StockTransactionId)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }

}