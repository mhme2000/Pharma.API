using Microsoft.EntityFrameworkCore;
using Pharma.API.Data.Interfaces;
using Pharma.API.Model;

namespace Pharma.API.Data.Repositories
{
    public class StockItemRepository : IStockItemRepository
    {
        private readonly PharmaContext _context;
        public StockItemRepository(PharmaContext context)
        {
            _context = context;
        }
        public void Add(StockItemModel stockItem)
        {
            _context.StockItem?.Add(stockItem);
            _context.SaveChanges();
        }

        public StockItemModel? GetById(int stockItemId)
        {
            return _context.StockItem?.AsNoTracking().Include(u => u.Stock).ThenInclude(v => v.Pharma).Include(t => t.Product).FirstOrDefault(u => u.StockItemId == stockItemId);
        }

        public IEnumerable<StockItemModel>? GetAll()
        {
            return _context.StockItem?.Where(t => t.StockItemId > 0).Include(u => u.Stock).ThenInclude(v => v.Pharma).Include(t => t.Product);
        }

        public void Update(StockItemModel stockItem)
        {
            _context.StockItem?.Update(stockItem);
            _context.SaveChanges();
        }

        public void Delete(StockItemModel stockItem)
        {
            _context.StockItem?.Remove(stockItem);
            _context.SaveChanges();
        }
    }

}