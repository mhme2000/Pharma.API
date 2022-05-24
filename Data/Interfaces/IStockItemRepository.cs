using Pharma.API.Model;

namespace Pharma.API.Data.Interfaces
{
    public interface IStockItemRepository
    {
        void Add(StockItemModel stockItem);
        StockItemModel? GetById(int stockItemId);
        IEnumerable<StockItemModel>? GetAll();
        void Delete(StockItemModel stockItem);
        void Update(StockItemModel stockItem);
    }

}