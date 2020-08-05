using System;

namespace PingDong.CleanArchitect.Core
{
    public class IntegrationEvent : ITracing
    {
        #region ctor

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

        #endregion

        #region Properties

        public string RequestId  { get; set; }
        public DateTime CreationDateInUtc { get; }

        #endregion

        #region ITracing

        public string TenantId { get; set; }

        public string CorrelationId { get; set; }

        #endregion
    }
}
