using MediatR;

namespace PingDong.CleanArchitect.Core
{
    public class Command<TResult> : IRequest<TResult>, ITracing
    {
        #region ctor

        public Command()
        {

        }

        public Command(string tenantId, string correlationId)
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
