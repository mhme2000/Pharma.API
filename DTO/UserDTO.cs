using AutoMapper;
using Pharma.API.Model;

namespace Pharma.API.DTO
{
    public class UserDTO
    {
        public int UserId { get; private set; }
        public string Cpf { get; private set; }
        public string UserType { get; private set; }
        public string PharmaName { get; private set; }
        public bool Active { get; set; }

        public class UserProfile : Profile
        {
            public UserProfile()
            {
                CreateMap<UserModel, UserDTO>()
                  .ForMember(dst => dst.Cpf, map => map.MapFrom(src => src.Person.Cpf))
                  .ForMember(dst => dst.UserType, map => map.MapFrom(src => src.UserType.Description))
                  .ForMember(dst => dst.PharmaName, map => map.MapFrom(src => src.Pharma.PharmaName));

            }
        }
    }
}