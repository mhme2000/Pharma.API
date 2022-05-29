using System.Text.Json.Serialization;

namespace Pharma.API.Model
{
    public class AddressModel
    {
        public int AddressId { get; private set; }
        public string? Street { get; set; }
        public int? Number { get; set; }
        public string? District { get; set; }
        public string? City { get; set; }
        public string? Zipcode { get; set; }
        public string? Complement { get; set; }
        public int PersonId { get; set; }
        [JsonIgnore]
        public PersonModel? Person { get; set; }
    }
}