using System;
using System.Runtime.Serialization;

namespace PingDong.CleanArchitect.Core
{
    /// <summary>
    /// Exception type for domain exceptions
    /// </summary>
    [Serializable]
    public class ObjectNotFoundException : DomainException
    {
        public ObjectNotFoundException(string target, string id, ITracing tracker)
            : base(EventIds.RequestDataNotExisted, $"The specified {target} '{id}' doesn't exist", tracker)
        {
            Id = id;
            Target = target;
        }

        protected ObjectNotFoundException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public string Id { get; }

        public string Target { get; }
    }
}
