using System.Threading.Tasks;

namespace PingDong.CleanArchitect.Service
{
    public interface ITenantValidator
    {
        Task<bool> IsValidAsync(string tenantId);
    }
}
