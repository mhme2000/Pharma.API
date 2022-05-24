using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pharma.API.Model;

namespace Pharma.API.Data.Mappings
{
    public class StockTransactionItemMapping : IEntityTypeConfiguration<StockTransactionItemModel>
    {
        public void Configure(EntityTypeBuilder<StockTransactionItemModel> builder)
        {
            builder.ToTable("StockTransactionItem");

            builder.HasKey(c => c.StockTransactionItemId);
            builder.Property(c => c.StockTransactionItemId).ValueGeneratedOnAdd();

        }
    }

}