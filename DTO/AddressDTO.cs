using AutoMapper;
using Pharma.API.Model;

namespace Pharma.API.DTO
{
    [AutoMap(typeof(AddressModel))]
    public class AddressDTO
    {
        public string? Street { get; set; }
        public int? Number { get; set; }
        public string? District { get; set; }
        public string? City { get; set; }
        public string? Zipcode { get; set; }
        public string? Complement { get; set; }
    }
}