using Pharma.API.DTO;
using Pharma.API.Model;

namespace Pharma.API.Services.Interfaces;

public interface IOrdersService
{
        void SaveOrder(OrderDTO order);
        void SeparateOrder(SeparateOrderDTO order);
        List<StockTransactionModel> GetAll();
        StockTransactionModel GetDetails(int stockTransactionId);
}