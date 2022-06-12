using System.Linq.Expressions;

namespace WholesaleMarketHall.Web.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id, CancellationToken cancellationToken);
        Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken);
        Task<List<T>> FindAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken);
        Task AddAsync(T entity, CancellationToken cancellationToken);
        Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
