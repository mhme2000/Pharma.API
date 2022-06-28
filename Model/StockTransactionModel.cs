    using System.Text.Json.Serialization;

namespace Pharma.API.Model
{
    public class StockTransactionModel
    {
        public int StockTransactionId { get; private set; }

        public DateTime CreatedAt { get; private set; } = DateTime.Today.Date;
        public int UserId { get; set; }
        [JsonIgnore]
        public UserModel User { get; private set; }
        public int TransactionTypeId { get; set; }
        [JsonIgnore]
        public TransactionTypeModel? TransactionType { get; private set; }
        public int TransactionStatusId { get; set; }
        [JsonIgnore]
        public TransactionStatusModel? TransactionStatus { get; private set; }
        public readonly List<StockTransactionItemModel> _stockTransactionItems = new List<StockTransactionItemModel>();
        public IReadOnlyCollection<StockTransactionItemModel> StockTransactionItems => _stockTransactionItems;

        // private static double AmountGenerate(List<StockTransactionItemModel> items)
        // {
        //     double amount = 0.0;
        //     foreach (var item in items)
        //     {
        //         amount += (item.Quantity * item.UnitaryValue);
        //     }
        //
        //     return amount;
        // }
    }
}
