using AutoMapper;
using Pharma.API.DTO;

namespace Pharma.API.Model
{
    [AutoMap(typeof(UserQuery))]
    public class UserModel
    {
        public int UserId { get; private set; }
        public int PersonId { get; set; }
        public PersonModel? Person { get; private set; }
        public int UserTypeId { get; set; }
        public UserTypeModel? UserType { get; private set; }
        public int PharmaId { get; set; }
        public PharmaModel? Pharma { get; private set; }
        public bool Active { get; set; }
    }
}