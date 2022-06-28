using Microsoft.EntityFrameworkCore;
using Pharma.API.Data.Interfaces;
using Pharma.API.Model;

namespace Pharma.API.Data.Repositories
{
    public class StockTransactionItemRepository : IStockTransactionItemRepository
    {
        private readonly PharmaContext _context;
        public StockTransactionItemRepository(PharmaContext context)
        {
            _context = context;
        }
        public void SaveItem(StockTransactionItemModel stockTransactionItem)
        {
            _context.StockTransactionItem?.Add(stockTransactionItem);
            
        }
        
        public List<StockTransactionItemModel>? GetByStockTransactionId(int stockTransactionId)
        {
            return _context.StockTransactionItem?.AsNoTracking().Where(t => t.StockTransactionId == stockTransactionId).ToList();
        }
    }

}