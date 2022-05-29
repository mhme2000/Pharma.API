using AutoMapper;
using Pharma.API.Model;

namespace Pharma.API.DTO
{
    [AutoMap(typeof(PersonModel))]
    public class PersonDTO
    {
       public int PersonId { get; private set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public List<AddressDTO> Addresses { get; set; }
    }
}