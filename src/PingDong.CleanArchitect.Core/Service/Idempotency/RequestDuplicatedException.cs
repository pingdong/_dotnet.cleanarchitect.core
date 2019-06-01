using System;

namespace PingDong.CleanArchitect.Service
{
    public class RequestDuplicatedException : Exception
    {
        public RequestDuplicatedException() : base()
        { }

        public RequestDuplicatedException(string message)
            : base(message)
        { }

        public RequestDuplicatedException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
