    using System.Text.Json.Serialization;

namespace Pharma.API.Model
{
    public class StockTransactionModel
    {
        public int StockTransactionId { get; private set; }
        public float Amount { get; private set; }
        public DateTime CreatedAt { get; private set; } = DateTime.Now;
        public int UserId { get; private set; }
        [JsonIgnore]
        public UserModel User { get; private set; }
        public int TransactionTypeId { get; private set; }
        [JsonIgnore]
        public TransactionTypeModel? TransactionType { get; private set; }
        public int TransactionStatusId { get; private set; }
        [JsonIgnore]
        public TransactionStatusModel? TransactionStatus { get; private set; }
        private readonly List<StockTransactionItemModel> _stockTransactionItems = new List<StockTransactionItemModel>();
        public IReadOnlyCollection<StockTransactionItemModel> StockTransactionItems => _stockTransactionItems;

    }
}