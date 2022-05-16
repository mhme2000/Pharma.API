using AutoMapper;
using Pharma.API.Model;

namespace Pharma.API.DTO
{
    public class UserQuery
    {
        public int UserId { get; private set; }
        public int PersonId { get; set; }
        public int UserTypeId { get; set; }
        public int PharmaId { get; set; }
        public bool Active { get; set; }
    }
}