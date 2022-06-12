using MediatR;
using WholesaleMarketHall.Web.MediatR.Application.Commands;
using WholesaleMarketHall.Web.MediatR.Application.Dtos;
using WholesaleMarketHall.Web.MediatR.Application.Mapping;
using WholesaleMarketHall.Web.MediatR.Domain.ProductAggregate;
using WholesaleMarketHall.Web.UnitOfWork;

namespace WholesaleMarketHall.Web.MediatR.Application.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductDto>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateProductCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<CreateProductDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = ObjectMapper.Mapper.Map<Product>(request);
            await _unitOfWork.Product().AddAsync(product, cancellationToken);
            await _unitOfWork.SaveAsync();
            return new CreateProductDto { Name = product.Name };
        }
    }
}
