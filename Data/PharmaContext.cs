using Microsoft.EntityFrameworkCore;
using Pharma.API.Data.Mappings;
using Pharma.API.Model;

namespace Pharma.API.Data
{
    public class PharmaContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql();
        }
        public DbSet<PharmaModel>? Pharma { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PharmaMapping());
        }
    }

}