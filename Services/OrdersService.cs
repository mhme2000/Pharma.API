using Pharma.API.Data;
using Pharma.API.Data.Interfaces;
using Pharma.API.DTO;
using Pharma.API.Model;
using Pharma.API.Services.Interfaces;

namespace Pharma.API.Services;

public class OrdersService : IOrdersService
{
    private readonly IStockTransactionRepository _stockTransactionRepository;
    private readonly IStockTransactionItemRepository _stockTransactionItemRepository;
    private readonly IStockItemRepository _stockItemRepository;
    private readonly PharmaContext _context;

    public OrdersService(IStockTransactionRepository stockTransactionRepository, IStockTransactionItemRepository stockTransactionItemRepository, IStockItemRepository stockItemRepository, PharmaContext context)
    {
        _stockTransactionRepository = stockTransactionRepository;
        _stockTransactionItemRepository = stockTransactionItemRepository;
        _stockItemRepository = stockItemRepository;
        _context = context;
    }
    public void SaveOrder(OrderDTO order)
    {
        var stockTransaction = new StockTransactionModel()
        {
            UserId = order.UserId,
            TransactionStatusId = (int)TransactionStatus.AguardandoSeparacao,
            TransactionTypeId = (int)TransactionType.SaidaPorPedidoDeProduto
        };
        var orderId = _stockTransactionRepository.Save(stockTransaction);
        foreach (var item in order.Items)
        {
            var stockItem =_stockItemRepository.GetById(item.StockItemId);
            if (stockItem != null && stockItem.StockItemId == item.StockItemId)
            {
                var stockTransactionItem = new StockTransactionItemModel()
                {
                    Quantity = item.Quantity,
                    UnitaryValue = stockItem.UnitaryValue,
                    StockItemId = item.StockItemId,
                    StockTransactionId = orderId,
                };
                _stockTransactionItemRepository.SaveItem(stockTransactionItem);
                _context.SaveChanges();
            }
        }
    }
    
    public void SeparateOrder(SeparateOrderDTO order)
    {
        var stockTransaction = _stockTransactionRepository.GetById(order.StockTransactionId);
        var stockTransactionItems = _stockTransactionItemRepository.GetByStockTransactionId(order.StockTransactionId);
        if (stockTransactionItems != null && stockTransactionItems.Count > 0)
        {
            stockTransaction.TransactionStatusId = (int)TransactionStatus.EmSeparacao;
            foreach (var item in stockTransactionItems)
            {
                if (item.StockItemId > 0)
                {
                    var stockItem =_stockItemRepository.GetById((int)item.StockItemId);
                    if (stockItem != null)
                    {
                        stockItem.UpdateBalance(item.Quantity);
                        _stockItemRepository.Update(stockItem);
                        _context.SaveChanges();
                    }
                }
                
            }
            _stockTransactionRepository.Update(stockTransaction);
            _context.SaveChanges();
        }
    }
    
    public List<StockTransactionModel> GetAll()
    {
        var stockTransactions = _stockTransactionRepository.GetAll();
        return stockTransactions;
    }

    public StockTransactionModel GetDetails(int stockTransactionId)
    {
        var stockTransaction = _stockTransactionRepository.GetById(stockTransactionId);
        return stockTransaction;
    }
}