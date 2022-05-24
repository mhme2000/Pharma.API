using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pharma.API.Model;

namespace Pharma.API.Data.Mappings
{
    public class TransactionStatusMapping : IEntityTypeConfiguration<TransactionStatusModel>
    {
        public void Configure(EntityTypeBuilder<TransactionStatusModel> builder)
        {
            builder.ToTable("TransactionStatus");
            builder.HasKey(x => x.TransactionStatusId);
            builder.Property(x => x.Description).HasColumnType("text");
            builder.HasMany(x => x.StockTransactions).WithOne(b => b.TransactionStatus).HasForeignKey(b => b.TransactionStatusId)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }

}