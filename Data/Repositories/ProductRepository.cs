using Microsoft.EntityFrameworkCore;
using Pharma.API.Data.Interfaces;
using Pharma.API.Model;

namespace Pharma.API.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly PharmaContext _context;
        public ProductRepository(PharmaContext context)
        {
            _context = context;
        }
        public void Add(ProductModel product)
        {
            _context.Product?.Add(product);
            _context.SaveChanges();
        }

        public ProductModel? GetById(int productId)
        {
            return _context.Product?.AsNoTracking().Include(r => r.ProductType).Include(s => s.UnitOfMeasurement).FirstOrDefault(t => t.ProductId == productId);
        }

        public IEnumerable<ProductModel>? GetAll()
        {
            return _context.Product?.Where(t => t.ProductId > 0).Include(r => r.ProductType).Include(s => s.UnitOfMeasurement);
        }

        public void Update(ProductModel product)
        {
            _context.Product?.Update(product);
            _context.SaveChanges();
        }

        public void Delete(ProductModel product)
        {
            _context.Product?.Remove(product);
            _context.SaveChanges();
        }
    }

}