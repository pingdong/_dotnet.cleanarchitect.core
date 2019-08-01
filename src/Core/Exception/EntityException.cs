using System;
using Microsoft.Extensions.Logging;

namespace PingDong.CleanArchitect.Core
{
    /// <summary>
    /// Exception type for domain exceptions
    /// </summary>
    public class EntityException : DomainException
    {
        public EntityException()
        { }

        public EntityException(int eventId, string message)
            : this(new EventId(eventId), message, null, null)
        { }

        public EntityException(EventId eventId, string message)
            : this(eventId, message, null, null)
        { }

        public EntityException(int eventId, string message, ITracker tracker)
            : this(new EventId(eventId), message, null, tracker)
        { }

        public EntityException(EventId eventId, string message, ITracker tracker)
            : this(eventId, message, null, tracker)
        { }

        public EntityException(EventId eventId, string message, Exception innerException, ITracker tracker)
            : base(eventId, message, innerException, tracker)
        { }
    }
}
