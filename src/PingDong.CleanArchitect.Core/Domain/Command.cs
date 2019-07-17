using System;
using MediatR;

namespace PingDong.CleanArchitect.Core
{
    public class Command : IRequest<bool>
    {
        public Command()
        {

        }

        public Command(Guid tenantId, Guid correlationId)
        {
            CorrelationId = correlationId;
            TenantId = tenantId;
        }

        public Guid TenantId { get; set; }

        public Guid CorrelationId { get; set; }
    }
}
