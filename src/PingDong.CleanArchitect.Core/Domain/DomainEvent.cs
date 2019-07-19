using MediatR;

namespace PingDong.CleanArchitect.Core
{
    public class DomainEvent : INotification, IMetadata
    {
        public DomainEvent()
        {

        }

        public DomainEvent(string tenantId, string correlationId)
        {
            CorrelationId = correlationId;
            TenantId = tenantId;
        }

        public string TenantId { get; set; }

        public string CorrelationId { get; set; }
    }
}
