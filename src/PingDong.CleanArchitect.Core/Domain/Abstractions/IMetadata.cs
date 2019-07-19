
namespace PingDong.CleanArchitect.Core
{
    public interface IMetadata
    {
        string TenantId { get; set; }

        string CorrelationId { get; set; }
    }
}
