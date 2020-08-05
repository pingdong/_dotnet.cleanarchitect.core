
namespace PingDong.CleanArchitect.Core
{
    public interface ITracing
    {
        string TenantId { get; set; }

        string CorrelationId { get; set; }
    }
}
