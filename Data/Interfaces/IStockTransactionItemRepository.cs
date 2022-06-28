using Pharma.API.Model;

namespace Pharma.API.Data.Interfaces
{
    public interface IStockTransactionItemRepository
    {
        void SaveItem(StockTransactionItemModel stockTransactionItem);
        List<StockTransactionItemModel>? GetByStockTransactionId(int stockTransactionId);
    }

}