using Microsoft.EntityFrameworkCore;
using Pharma.API.Data.Mappings;
using Pharma.API.Model;

namespace Pharma.API.Data
{
    public class PharmaContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(connectionString: "Host=localhost;Port=12350;Pooling=true;Database=Pharma;User Id=postgres;Password=123456;");
        }
        public DbSet<PharmaModel>? Pharma { get; set; }
        public DbSet<UserModel>? User { get; set; }
        public DbSet<UserTypeModel>? UserType { get; set; }
        public DbSet<PersonModel>? Person { get; set; }
        public DbSet<ProductModel>? Product { get; set; }
        public DbSet<ProductTypeModel>? ProductType { get; set; }
        public DbSet<UnitOfMeasurementModel>? UnitOfMeasurement { get; set; }
        public DbSet<StockModel>? Stock { get; set; }
        public DbSet<StockItemModel>? StockItem { get; set; }
        public DbSet<StockTransactionModel>? StockTransaction { get; set; }
        public DbSet<StockTransactionItemModel>? StockTransactionItem { get; set; }
        public DbSet<TransactionStatusModel>? TransactionStatus { get; set; }
        public DbSet<TransactionTypeModel>? TransactionType { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PharmaMapping());
            modelBuilder.ApplyConfiguration(new UserMapping());
            modelBuilder.ApplyConfiguration(new UserTypeMapping());
            modelBuilder.ApplyConfiguration(new PersonMapping());
            modelBuilder.ApplyConfiguration(new ProductMapping());
            modelBuilder.ApplyConfiguration(new ProductTypeMapping());
            modelBuilder.ApplyConfiguration(new UnitOfMeasurementMapping());
            modelBuilder.ApplyConfiguration(new StockMapping());
            modelBuilder.ApplyConfiguration(new StockItemMapping());
            modelBuilder.ApplyConfiguration(new StockTransactionMapping());
            modelBuilder.ApplyConfiguration(new StockTransactionItemMapping());
            modelBuilder.ApplyConfiguration(new TransactionStatusMapping());
            modelBuilder.ApplyConfiguration(new TransactionTypeMapping());
        }
    }

}