using System;
using System.Runtime.Serialization;
using Microsoft.Extensions.Logging;
using PingDong.CleanArchitect.Core;

namespace PingDong.CleanArchitect.Service
{
    [Serializable]
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

        protected RequestDuplicatedException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public EventId EventId => EventIds.DuplicatedRequest;

        public string RequestId { get; }
    }
}
