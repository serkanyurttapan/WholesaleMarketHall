using AutoMapper;
using WholesaleMarketHall.Web.MediatR.Application.Dtos;
using WholesaleMarketHall.Web.MediatR.Domain.ProductAggregate;

namespace WholesaleMarketHall.Web.MediatR.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<ProductDetail, ProductDetailDto>().ReverseMap();
        }
    }
}
