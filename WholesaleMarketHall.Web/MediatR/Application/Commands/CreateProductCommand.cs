using MediatR;
using WholesaleMarketHall.Web.MediatR.Application.Dtos;

namespace WholesaleMarketHall.Web.MediatR.Application.Commands
{
    public class CreateProductCommand : IRequest<CreateProductDto>
    {
    }
}
