using AutoMapper;
using Pharma.API.Model;

namespace Pharma.API.DTO
{
    public class StockDTO
    {
        public int StockId { get; private set; }
        public string Description { get; set; }
        public string Pharma { get; set; }

        public class StockProfile : Profile
        {
            public StockProfile()
            {
                CreateMap<StockModel, StockDTO>()
                  .ForMember(dst => dst.Pharma, map => map.MapFrom(src => src.Pharma.PharmaName));

            }
        }
    }
}