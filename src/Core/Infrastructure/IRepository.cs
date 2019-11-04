using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using PingDong.CleanArchitect.Core;

namespace PingDong.CleanArchitect.Infrastructure
{
    public interface IRepository<TId, T> where T: Entity<TId>
    {
        IUnitOfWork UnitOfWork { get; }

        Task<IList<T>> ListAsync();

        Task AddAsync(T entity);

        Task AddAsync(IList<T> entities);

        Task RemoveAsync(TId id);

        Task RemoveAsync(IList<TId> id);

        Task UpdateAsync(T entity);
        
        Task UpdateAsync(IList<T> entities);

        Task<T> FindByIdAsync(TId id, bool throwIfMissing = true);

        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);

        Task<IList<T>> WhereAsync(Expression<Func<T, bool>> predicate);
    }
}
