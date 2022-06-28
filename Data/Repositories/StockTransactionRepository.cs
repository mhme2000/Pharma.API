using Microsoft.EntityFrameworkCore;
using Pharma.API.Data.Interfaces;
using Pharma.API.Model;

namespace Pharma.API.Data.Repositories
{
    public class StockTransactionRepository : IStockTransactionRepository
    {
        private readonly PharmaContext _context;
        public StockTransactionRepository(PharmaContext context)
        {
            _context = context;
        }
        public int Save(StockTransactionModel stockTransaction)
        {
            _context.StockTransaction?.Add(stockTransaction);
            _context.SaveChanges();
            return stockTransaction.StockTransactionId;
        }
        
        public StockTransactionModel? GetById(int stockTransactionId)
        {
            return _context.StockTransaction?.Include(t => t.StockTransactionItems).ThenInclude(t => t.StockItem).ThenInclude((t => t.Product)).Where(t => t.StockTransactionId == stockTransactionId).FirstOrDefault();
        }
        
        public void Update(StockTransactionModel stockTransaction)
        {
            _context.StockTransaction?.Update(stockTransaction);
        }
        
        public List<StockTransactionModel>? GetAll()
        {
            return _context.StockTransaction?.Where(t => t.TransactionType.TransactionTypeId == (int)TransactionType.SaidaPorPedidoDeProduto).ToList();
        }
    }

}