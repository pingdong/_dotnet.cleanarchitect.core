using MediatR;

namespace PingDong.CleanArchitect.Core
{
    public class Command : IRequest<bool>
    {
        public Command()
        {

        }

        public Command(string correlationId)
        {
            CorrelationId = correlationId;
        }

        public string CorrelationId { get; set; }
    }
}
