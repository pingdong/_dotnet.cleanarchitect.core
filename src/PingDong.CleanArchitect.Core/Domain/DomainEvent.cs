using System;
using MediatR;

namespace PingDong.CleanArchitect.Core
{
    public class DomainEvent : INotification
    {
        public DomainEvent()
        {

        }

        public DomainEvent(Guid tenantId, Guid correlationId)
        {
            CorrelationId = correlationId;
            TenantId = tenantId;
        }

        public Guid TenantId { get; set; }

        public Guid CorrelationId { get; set; }
    }
}
