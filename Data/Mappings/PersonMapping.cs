using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pharma.API.Model;

namespace Pharma.API.Data.Mappings
{
    public class PersonMapping : IEntityTypeConfiguration<PersonModel>
    {
        public void Configure(EntityTypeBuilder<PersonModel> builder)
        {
            builder.ToTable("Person");

            builder.HasKey(c => c.PersonId);
            builder.Property(c => c.PersonId).ValueGeneratedOnAdd();
            builder.HasMany(x => x.User).WithOne(b => b.Person).HasForeignKey(b => b.PersonId)
            .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(x => x.Addresses).WithOne(b => b.Person).HasForeignKey(b => b.PersonId)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }

}