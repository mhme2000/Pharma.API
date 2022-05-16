using AutoMapper;
using Pharma.API.Model;

namespace Pharma.API.DTO
{
    [AutoMap(typeof(PharmaModel))]
    public class PharmaDTO
    {
        public int PharmaId { get; set; }
        public string? PharmaName { get; set; }
    }
}