using System.Text.Json.Serialization;

namespace Pharma.API.Model
{
    public class StockModel
    {
        public int StockId { get; private set; }
        public string Description { get; set; }
        public int PharmaId { get; set; }
        [JsonIgnore]
        public PharmaModel? Pharma { get; set; }
        private readonly List<StockItemModel> _stockItems = new List<StockItemModel>();
        public IReadOnlyCollection<StockItemModel> StockItems => _stockItems;
    }
}