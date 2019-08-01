using System;
using Microsoft.Extensions.Logging;

namespace PingDong.CleanArchitect.Core
{
    /// <summary>
    /// Exception type for domain exceptions
    /// </summary>
    public class IntegrationEventException : DomainException
    {
        public IntegrationEventException()
        {
        }

        public IntegrationEventException(int eventId, string message)
            : this(new EventId(eventId), message, null, null)
        {
        }

        public IntegrationEventException(EventId eventId, string message)
            : this(eventId, message, null, null)
        {
        }

        public IntegrationEventException(int eventId, string message, ITracker tracker)
            : this(new EventId(eventId), message, null, tracker)
        {
        }

        public IntegrationEventException(EventId eventId, string message, ITracker tracker)
            : this(eventId, message, null, tracker)
        {
        }

        public IntegrationEventException(EventId eventId, string message, Exception innerException, ITracker tracker)
            : base(eventId, message, innerException, tracker)
        {
        }
    }
}
