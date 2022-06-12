using WholesaleMarketHall.Web.DBConnection;
using WholesaleMarketHall.Web.Repository;

namespace WholesaleMarketHall.Web.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        private ProductContext context;

        public UnitOfWork(ProductContext context)
        {
            this.context = context;
            Product();
        }

        public async Task<int> SaveAsync()
        {
            return await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IProductRepository Product()
        {
            return new ProductRepository(this.context);
        }
    }
}