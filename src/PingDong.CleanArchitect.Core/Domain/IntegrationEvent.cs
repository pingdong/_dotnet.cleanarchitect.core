using System;

namespace PingDong.CleanArchitect.Core
{
    public class IntegrationEvent : IMetadata
    {
        public IntegrationEvent() 
            : this(string.Empty, string.Empty, string.Empty)
        {

        }

        public IntegrationEvent(string requestId, string tenantId, string correlationId)
        {
            RequestId = requestId;
            CreationDateInUtc = DateTime.UtcNow;
            CorrelationId = correlationId;
            TenantId = tenantId;
        }

        public string RequestId  { get; set; }
        public DateTime CreationDateInUtc { get; }

        #region IMetadata
        public string CorrelationId { get; set; }
        public string TenantId { get; set; }
        #endregion
    }
}
