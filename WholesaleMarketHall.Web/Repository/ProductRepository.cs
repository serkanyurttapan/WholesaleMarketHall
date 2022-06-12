using WholesaleMarketHall.Web.DBConnection;
using WholesaleMarketHall.Web.MediatR.Domain.ProductAggregate;

namespace WholesaleMarketHall.Web.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ProductContext context) : base(context)
        {
        }
    }
}
