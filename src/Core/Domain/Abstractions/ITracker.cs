
namespace PingDong.CleanArchitect.Core
{
    public interface ITracker
    {
        string TenantId { get; set; }

        string CorrelationId { get; set; }
    }
}
