using Microsoft.Extensions.Logging;

namespace PingDong.CleanArchitect.Core
{
    /// <summary>
    /// Exception type for domain exceptions
    /// </summary>
    public class DomainException : System.Exception
    {
        public DomainException()
        { }

        public DomainException(EventId eventId, string message, ITracker tracker)
            : this(eventId, message, null, tracker)
        {

        }

        public DomainException(EventId eventId, string message, System.Exception innerException, ITracker tracker)
            : base(message, innerException)
        {
            Tracker = tracker;
            EventId = eventId;
        }

        public ITracker Tracker { get; }

        public EventId EventId { get; }
    }
}
