using System.Text.Json.Serialization;

namespace Pharma.API.Model
{
    public class StockTransactionItemModel
    {
        public int StockTransactionItemId { get; private set; }
        public int StockTransactionId { get; private set; }
        [JsonIgnore]
        public StockTransactionModel? StockTransaction { get; private set; }
        public int? StockItemId { get; private set; }
        [JsonIgnore]
        public StockItemModel? StockItem { get; private set; }
        public int Quantity { get; private set; }
  
    }
}