using Microsoft.Extensions.Logging;

namespace PingDong.CleanArchitect.Core
{
    /// <summary>
    /// Exception type for domain exceptions
    /// </summary>
    public class ObjectNotFoundException : DomainException
    {
        public ObjectNotFoundException(string target, string id, ITracing tracker)
            : base(EventIds.RequestDataNotExisted, $"The specified {target} '{id}' doesn't exist", tracker)
        {
            Id = id;
            Target = target;
        }

        public string Id { get; }

        public string Target { get; }
    }
}
