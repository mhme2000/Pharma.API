using AutoMapper;
using Pharma.API.Model;

namespace Pharma.API.DTO
{
    [AutoMap(typeof(StockItemModel))]
    public class StockItemDTO
    {
        public int StockItemId { get; private set; }
        public int StockId { get; private set; }
        public StockModel? Stock { get; set; }
        public int ProductId { get; private set; }
        public ProductModel? Product { get; set; }
        public string Lote { get; private set; }
        public string DataValidade { get; private set; }
        public int Saldo { get; private set; }
        public float UnitaryValue { get; private set; }

    }
}