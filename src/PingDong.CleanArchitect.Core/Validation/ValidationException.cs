using System;

namespace PingDong.CleanArchitect.Core
{
    public class ValidationViolatedException : Exception
    {
        public ValidationViolatedException() : base()
        { }

        public ValidationViolatedException(string message)
            : base(message)
        { }

        public ValidationViolatedException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
