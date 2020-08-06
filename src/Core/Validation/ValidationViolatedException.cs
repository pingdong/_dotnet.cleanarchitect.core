using System;
using System.Runtime.Serialization;

namespace PingDong.CleanArchitect.Core.Validation
{
    [Serializable]
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

        protected ValidationViolatedException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        { }
    }
}
