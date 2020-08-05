using MediatR;

namespace PingDong.CleanArchitect.Core
{
    public class DomainEvent : INotification, ITracing
    {
        #region ctor

        public DomainEvent()
        {

        }

        public DomainEvent(string tenantId, string correlationId)
        {
            CorrelationId = correlationId;
            TenantId = tenantId;
        }

        #endregion

        #region ITracing

        public string TenantId { get; set; }

        public string CorrelationId { get; set; }

        #endregion
    }
}
