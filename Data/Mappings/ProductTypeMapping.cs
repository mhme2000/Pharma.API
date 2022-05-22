using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pharma.API.Model;

namespace Pharma.API.Data.Mappings
{
    public class ProductTypeMapping : IEntityTypeConfiguration<ProductTypeModel>
    {
        public void Configure(EntityTypeBuilder<ProductTypeModel> builder)
        {
            builder.ToTable("ProductType");
            builder.HasKey(x => x.ProductTypeId);
            builder.Property(x => x.Description).HasColumnType("text");
            builder.HasMany(x => x.Products).WithOne(b => b.ProductType).HasForeignKey(b => b.ProductTypeId)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }

}