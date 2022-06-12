using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WholesaleMarketHall.Web.DBConnection;

namespace WholesaleMarketHall.Web.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ProductContext context;
        public GenericRepository(ProductContext context)
        {
            this.context = context;
        }
        public async Task AddAsync(T entity,CancellationToken cancellationToken)
        {
           await context.Set<T>().AddAsync(entity,cancellationToken);
        }
        public async Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken)
        {
           await context.Set<T>().AddRangeAsync(entities, cancellationToken);
        }
        public async Task<List<T>> FindAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken)
        {
            return await context.Set<T>().Where(expression).ToListAsync(cancellationToken);
        }
        public async Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await context.Set<T>().ToListAsync(cancellationToken);
        }
        public async Task<T> GetByIdAsync(int id,CancellationToken cancellationToken)
        {
            return await context.Set<T>().FindAsync(id, cancellationToken);
        }
        public void Remove(T entity)
        {
            context.Set<T>().Remove(entity);
        }
        public void RemoveRange(IEnumerable<T> entities)
        {
            context.Set<T>().RemoveRange(entities);
        }
    }
}
