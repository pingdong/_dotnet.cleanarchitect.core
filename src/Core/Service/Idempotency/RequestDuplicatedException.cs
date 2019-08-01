using System;
using Microsoft.Extensions.Logging;
using PingDong.CleanArchitect.Core;

namespace PingDong.CleanArchitect.Service
{
    public class RequestDuplicatedException : Exception
    {
        public RequestDuplicatedException()
        { }

        public RequestDuplicatedException(string requestId)
            : this($"Request '{requestId}' was already processed", null, requestId)
        { }

        public RequestDuplicatedException(string message, Exception innerException, string requestId)
            : base(message, innerException)
        {
            RequestId = requestId;
        }

        public EventId EventId => EventIds.DuplicatedRequest;

        public string RequestId { get; }
    }
}
