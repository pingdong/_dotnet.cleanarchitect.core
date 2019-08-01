using System.Collections.Generic;
using System.Threading.Tasks;
using PingDong.CleanArchitect.Core;

namespace PingDong.CleanArchitect.Infrastructure
{
    public interface IRepository<in TId, T> where T: Entity<TId>
    {
        IUnitOfWork UnitOfWork { get; }

        Task<IList<T>> ListAsync();

        Task AddAsync(T entity);

        Task RemoveAsync(TId id);

        Task UpdateAsync(T entity);

        Task<T> FindByIdAsync(TId id);         
    }
}
