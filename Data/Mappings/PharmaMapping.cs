using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pharma.API.Model;

namespace Pharma.API.Data.Mappings
{
    public class PharmaMapping : IEntityTypeConfiguration<PharmaModel>
    {
        public void Configure(EntityTypeBuilder<PharmaModel> builder)
        {
            //builder.ToTable("Pharma");

            //builder.HasKey(c => c.PharmaId);
            //builder.Property(c => c.NomeContato).IsRequired().HasMaxLength(50);
            //builder.Property(c => c.NumeroContato).IsRequired().HasMaxLength(20);
            //builder.Property(c => c.FotoContato);
            //builder.Property(c => c.EnderecoContato).HasMaxLength(50);
        }
    }

}