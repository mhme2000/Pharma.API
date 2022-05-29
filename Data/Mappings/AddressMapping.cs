using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pharma.API.Model;

namespace Pharma.API.Data.Mappings
{
    public class AddressMapping : IEntityTypeConfiguration<AddressModel>
    {
        public void Configure(EntityTypeBuilder<AddressModel> builder)
        {
            builder.ToTable("Address");

            builder.HasKey(c => c.AddressId);
            builder.Property(c => c.AddressId).ValueGeneratedOnAdd();
        }
    }

}