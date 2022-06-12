using Microsoft.EntityFrameworkCore;
using WholesaleMarketHall.Web.MediatR.Domain.ProductAggregate;

namespace WholesaleMarketHall.Web.DBConnection
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }
        public DbSet<Product>? Product { get; set; }
    }
}
