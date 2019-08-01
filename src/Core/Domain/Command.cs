using MediatR;

namespace PingDong.CleanArchitect.Core
{
    public class Command<TResult> : IRequest<TResult>, ITracker
    {
        public Command()
        {

        }

        public Command(string tenantId, string correlationId)
        {
            CorrelationId = correlationId;
            TenantId = tenantId;
        }

        public string TenantId { get; set; }

        public string CorrelationId { get; set; }
    }
}
