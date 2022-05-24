using Microsoft.EntityFrameworkCore;
using Pharma.API.Data.Interfaces;
using Pharma.API.Model;

namespace Pharma.API.Data.Repositories
{
    public class StockRepository : IStockRepository
    {
        private readonly PharmaContext _context;
        public StockRepository(PharmaContext context)
        {
            _context = context;
        }
        public void Add(StockModel stock)
        {
            _context.Stock?.Add(stock);
            _context.SaveChanges();
        }

        public StockModel? GetById(int stockId)
        {
            return _context.Stock?.AsNoTracking().Include(u => u.Pharma).FirstOrDefault(t => t.StockId == stockId);
        }

        public IEnumerable<StockModel>? GetAll()
        {
            return _context.Stock?.Where(t => t.StockId > 0).Include(u => u.Pharma);
        }

        public void Update(StockModel stock)
        {
            _context.Stock?.Update(stock);
            _context.SaveChanges();
        }

        public void Delete(StockModel stock)
        {
            _context.Stock?.Remove(stock);
            _context.SaveChanges();
        }
    }

}