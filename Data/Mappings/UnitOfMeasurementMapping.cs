using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pharma.API.Model;

namespace Pharma.API.Data.Mappings
{
    public class UnitOfMeasurementMapping : IEntityTypeConfiguration<UnitOfMeasurementModel>
    {
        public void Configure(EntityTypeBuilder<UnitOfMeasurementModel> builder)
        {
            builder.ToTable("UnitOfMeasurement");
            builder.HasKey(x => x.UnitOfMeasurementId);
            builder.Property(x => x.Description).HasColumnType("text");
            builder.HasMany(x => x.Products).WithOne(b => b.UnitOfMeasurement).HasForeignKey(b => b.ProductTypeId)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }

}