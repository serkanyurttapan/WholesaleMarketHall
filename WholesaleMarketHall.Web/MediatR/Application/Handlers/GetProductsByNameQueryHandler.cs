using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WholesaleMarketHall.Web.DBConnection;
using WholesaleMarketHall.Web.MediatR.Application.Dtos;
using WholesaleMarketHall.Web.MediatR.Application.Mapping;
using WholesaleMarketHall.Web.MediatR.Application.Queries;
using WholesaleMarketHall.Web.UnitOfWork;

namespace WholesaleMarketHall.Web.MediatR.Application.Handlers
{
    public class GetProductsByNameQueryHandler : IRequestHandler<GetProductsByNameQuery, List<ProductDto>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetProductsByNameQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<ProductDto>> Handle(GetProductsByNameQuery request, CancellationToken cancellationToken)
        {
            var products = await _unitOfWork.Product().FindAsync(x => x.Name == request.Name, cancellationToken);
            return ObjectMapper.Mapper.Map<List<ProductDto>>(products);
        }
    }
}
