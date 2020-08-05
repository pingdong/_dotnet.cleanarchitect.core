using System;
using Microsoft.Extensions.Logging;

namespace PingDong.CleanArchitect.Core
{
    /// <summary>
    /// Exception type for domain exceptions
    /// </summary>
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

        public ITracing Tracing { get; }

        public EventId EventId { get; }
    }
}
