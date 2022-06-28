using Pharma.API.Model;

namespace Pharma.API.Data.Interfaces
{
    public interface IStockTransactionRepository
    {
        int Save(StockTransactionModel stockTransaction);
        StockTransactionModel? GetById(int stockTransactionId);
        List<StockTransactionModel>? GetAll();
        void Update(StockTransactionModel stockTransaction);
    }

}