using System.Text.Json.Serialization;

namespace Pharma.API.Model
{
    public class StockTransactionItemModel
    {
        public int StockTransactionItemId { get; private set; }
        public int StockTransactionId { get; set; }
        [JsonIgnore]
        public StockTransactionModel? StockTransaction { get; private set; }
        public int? StockItemId { get; set; }
        [JsonIgnore]
        public StockItemModel? StockItem { get; private set; }
        public int Quantity { get; set; }
        public double UnitaryValue { get; set; }
    }
}