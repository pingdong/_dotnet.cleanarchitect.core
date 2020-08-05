using Microsoft.Extensions.Logging;

namespace PingDong.CleanArchitect.Core
{
    public sealed class EventIds
    {
        public static readonly EventId Failure = new EventId(0);
        public static readonly EventId Success = new EventId(1);
        public static readonly EventId Starting = new EventId(2);
        public static readonly EventId Submitted = new EventId(3);
               
        public static readonly EventId DuplicatedRequest = new EventId(102);
               
        public static readonly EventId InvalidData = new EventId(201);
        public static readonly EventId RequestDataNotExisted = new EventId(202);
        public static readonly EventId RequestDataDuplicated = new EventId(203);
        public static readonly EventId BusinessLogicViolated = new EventId(204);
               
        public static readonly EventId InvalidDomainEvent = new EventId(400);
               
        public static readonly EventId InvalidIntegrationEvent = new EventId(500);
    }
}
