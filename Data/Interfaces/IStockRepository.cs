using Pharma.API.Model;

namespace Pharma.API.Data.Interfaces
{
    public interface IStockRepository
    {
        void Add(StockModel stock);
        StockModel? GetById(int stockId);
        IEnumerable<StockModel>? GetAll();
        void Delete(StockModel stock);
        void Update(StockModel stock);
    }

}