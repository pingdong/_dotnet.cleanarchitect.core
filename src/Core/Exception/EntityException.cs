using System;
using System.Runtime.Serialization;
using Microsoft.Extensions.Logging;

namespace PingDong.CleanArchitect.Core
{
    /// <summary>
    /// Exception type for domain exceptions
    /// </summary>
    [Serializable]
    public class EntityException : DomainException
    {
        public EntityException(int eventId, string message)
            : this(new EventId(eventId), message, null, null)
        { }

        public EntityException(EventId eventId, string message)
            : this(eventId, message, null, null)
        { }

        public EntityException(int eventId, string message, ITracing tracker)
            : this(new EventId(eventId), message, null, tracker)
        { }

        public EntityException(EventId eventId, string message, ITracing tracker)
            : this(eventId, message, null, tracker)
        { }

        public EntityException(EventId eventId, string message, Exception innerException, ITracing tracker)
            : base(eventId, message, innerException, tracker)
        { }

        protected EntityException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        { }
    }
}
