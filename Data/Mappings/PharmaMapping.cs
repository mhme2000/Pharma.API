using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pharma.API.Model;

namespace Pharma.API.Data.Mappings
{
    public class PharmaMapping : IEntityTypeConfiguration<PharmaModel>
    {
        public void Configure(EntityTypeBuilder<PharmaModel> builder)
        {
            builder.ToTable("Pharma");

            builder.HasKey(c => c.PharmaId);
            builder.Property(c => c.PharmaId).ValueGeneratedOnAdd();
            builder.Property(c => c.PharmaName).HasColumnType("text").IsRequired();
            builder.HasMany(x => x.Users).WithOne(b => b.Pharma).HasForeignKey(b => b.PharmaId)
            .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(x => x.Stocks).WithOne(b => b.Pharma).HasForeignKey(b => b.PharmaId)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }

}