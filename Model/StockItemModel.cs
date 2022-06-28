using System.Text.Json.Serialization;

namespace Pharma.API.Model
{
    public class StockItemModel
    {
        public int StockItemId { get; private set; }
        public int StockId { get; set; }
        [JsonIgnore]
        public StockModel? Stock { get; private set; }
        public int ProductId { get; set; }
        [JsonIgnore]
        public ProductModel? Product { get; private set; }
        public string Batch { get; set; }
        public string ExpirationDate { get; set; }
        public int Balance { get; private set; }   
        public float UnitaryValue { get; set; }
        private readonly List<StockTransactionItemModel> _stockTransactionItems = new List<StockTransactionItemModel>();
        public IReadOnlyCollection<StockTransactionItemModel> StockTransactionItems => _stockTransactionItems;

        public void UpdateBalance(int quantity)
        {
            Balance -= quantity;
        }
    }
}