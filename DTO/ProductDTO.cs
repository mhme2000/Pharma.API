using AutoMapper;
using Pharma.API.Model;

namespace Pharma.API.DTO
{
    public class ProductDTO
    {
        public int ProductId { get; private set; }
        public string Description { get; private set; }
        public string ProductType { get; private set; }
        public string UnitOfMeasurement { get; private set; }
        public bool Active { get; set; }
        public string? Photo { get; set; }

        public class ProductProfile : Profile
        {
            public ProductProfile()
            {
                CreateMap<ProductModel, ProductDTO>()
                  .ForMember(dst => dst.ProductType, map => map.MapFrom(src => src.ProductType.Description))
                  .ForMember(dst => dst.UnitOfMeasurement, map => map.MapFrom(src => src.UnitOfMeasurement.Description))
                  .ForMember(dst => dst.Photo, map => map.MapFrom(src => src.Image));
            }
        }

    }
}