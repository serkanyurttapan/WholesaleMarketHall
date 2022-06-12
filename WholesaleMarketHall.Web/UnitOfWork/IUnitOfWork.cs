using WholesaleMarketHall.Web.Repository;

namespace WholesaleMarketHall.Web.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Product();
        Task<int> SaveAsync();
    }
}
