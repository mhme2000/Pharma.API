using AutoMapper;
using Pharma.API.DTO;
using System.Text.Json.Serialization;

namespace Pharma.API.Model
{
    public class UserModel
    {
        public int UserId { get; private set; }
        public int PersonId { get; set; }
        [JsonIgnore]
        public PersonModel Person { get; private set; }
        public int UserTypeId { get; set; }
        [JsonIgnore]
        public UserTypeModel UserType { get; private set; }
        public int PharmaId { get; set; }
        [JsonIgnore]
        public PharmaModel? Pharma { get; private set; }
        public bool Active { get; set; }
    }
}