using MediatR;

namespace PingDong.CleanArchitect.Core
{
    public class DomainEvent : INotification
    {
        public DomainEvent()
        {

        }

        public DomainEvent(string correlationId)
        {
            CorrelationId = correlationId;
        }

        public string CorrelationId { get; set; }
    }
}
