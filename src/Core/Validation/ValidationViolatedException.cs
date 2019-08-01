using System;

namespace PingDong.CleanArchitect.Core.Validation
{
    public class ValidationViolatedException : Exception
    {
        public ValidationViolatedException()
        { }

        public ValidationViolatedException(string message)
            : base(message)
        { }

        public ValidationViolatedException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
