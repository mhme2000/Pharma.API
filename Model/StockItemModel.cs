using System.Text.Json.Serialization;

namespace Pharma.API.Model
{
    public class StockItemModel
    {
        public int StockItemId { get; private set; }
        public int StockId { get; private set; }
        [JsonIgnore]
        public StockModel? Stock { get; set; }
        public int ProductId { get; private set; }
        [JsonIgnore]
        public ProductModel? Product { get; set; }
        public string Batch { get; private set; }
        public DateTime ExpirationDate { get; private set; }
        public int Balance { get; private set; }   
        public float UnitaryValue { get; private set; }
        private readonly List<StockTransactionItemModel> _stockTransactionItems = new List<StockTransactionItemModel>();
        public IReadOnlyCollection<StockTransactionItemModel> StockTransactionItems => _stockTransactionItems;
    }
}