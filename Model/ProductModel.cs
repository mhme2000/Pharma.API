using System.Text.Json.Serialization;

namespace Pharma.API.Model
{
    public class ProductModel
    {
        public int ProductId { get; private set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public bool Active  { get; set; }
        public int ProductTypeId { get; set; }
        [JsonIgnore]
        public ProductTypeModel? ProductType { get; set; }
        public int UnitOfMeasurementId { get; set; }
        [JsonIgnore]
        public UnitOfMeasurementModel? UnitOfMeasurement { get; set; }
    }
}