using System.Threading.Tasks;
using PingDong.CleanArchitect.Service;

namespace PingDong.CleanArchitect.Infrastructure
{
    public interface IClientRequestRepository<TId>
    {
        Task AddAsync(ClientRequest<TId> request);

        Task<ClientRequest<TId>> FindByIdAsync(TId id);      
        
        Task<int> SaveChangesAsync();
    }
}
