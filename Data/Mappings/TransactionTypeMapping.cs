using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pharma.API.Model;

namespace Pharma.API.Data.Mappings
{
    public class TransactionTypeMapping : IEntityTypeConfiguration<TransactionTypeModel>
    {
        public void Configure(EntityTypeBuilder<TransactionTypeModel> builder)
        {
            builder.ToTable("TransactionType");
            builder.HasKey(x => x.TransactionTypeId);
            builder.Property(x => x.Description).HasColumnType("text");
            builder.HasMany(x => x.StockTransactions).WithOne(b => b.TransactionType).HasForeignKey(b => b.TransactionTypeId)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }

}