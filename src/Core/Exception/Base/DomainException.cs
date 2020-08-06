using System;
using System.Runtime.Serialization;
using Microsoft.Extensions.Logging;

namespace PingDong.CleanArchitect.Core
{
    /// <summary>
    /// Exception type for domain exceptions
    /// </summary>
    [Serializable]
    public class DomainException : Exception
    {
        public DomainException(EventId eventId, string message, ITracing tracing)
            : this(eventId, message, null, tracing)
        {

        }

        public DomainException(EventId eventId, string message, Exception innerException, ITracing tracing)
            : base(message, innerException)
        {
            Tracing = tracing;
            EventId = eventId;
        }

        protected DomainException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public ITracing Tracing { get; }

        public EventId EventId { get; }
    }
}
