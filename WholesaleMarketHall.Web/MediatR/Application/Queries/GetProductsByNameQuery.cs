using MediatR;
using WholesaleMarketHall.Web.MediatR.Application.Dtos;

namespace WholesaleMarketHall.Web.MediatR.Application.Queries
{
    public class GetProductsByNameQuery : IRequest<List<ProductDto>>
    {
        public string Name { get; set; }
    }
}
