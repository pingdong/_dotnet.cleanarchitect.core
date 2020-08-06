using System.Collections.Generic;

namespace PingDong.CleanArchitect.Core
{
    public abstract class Entity<T> : ITracing
    {
        #region Properties

        public virtual T Id { get; protected set; }

        #endregion

        #region ITracing

        public string TenantId { get; set; }

        public string CorrelationId { get; set; }

        #endregion

        #region Domain Events

        private List<DomainEvent> _domainEvents;
        public IReadOnlyCollection<DomainEvent> DomainEvents => _domainEvents?.AsReadOnly();

        public void AddDomainEvent(DomainEvent @event)
        {
            @event.CorrelationId = CorrelationId;
            @event.TenantId = TenantId;

            _domainEvents = _domainEvents ?? new List<DomainEvent>();
            _domainEvents.Add(@event);
        }

        public void RemoveDomainEvent(DomainEvent eventItem)
        {
            _domainEvents?.Remove(eventItem);
        }

        public void ClearDomainEvents()
        {
            _domainEvents?.Clear();
        }

        #endregion

        #region Object

        public bool IsTransient()
        {
            return EqualityComparer<T>.Default.Equals(Id, default);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Entity<T>))
                return false;

            if (ReferenceEquals(this, obj))
                return true;

            if (GetType() != obj.GetType())
                return false;

            var item = (Entity<T>)obj;

            if (item.IsTransient() || IsTransient())
                return false;
            
            return item.Id.Equals(Id);
        }

        public override int GetHashCode()
        {
            if (!IsTransient())
            {
                if (!_hashCode.HasValue)
                    // XOR for random distribution
                    // http://blogs.msdn.com/b/ericlippert/archive/2011/02/28/guidelines-and-rules-for-gethashcode.aspx
                    _hashCode = Id.GetHashCode() ^ 31; 

                return _hashCode.Value;
            }
            
            return base.GetHashCode();
        }
        private int? _hashCode;

        public static bool operator == (Entity<T> left, Entity<T> right)
        {
            //if (Equals(left, null))
            //    return Equals(right, null);
            
            //return left.Equals(right);
            
            return left?.Equals(right) ?? Equals(right, null);
        }

        public static bool operator != (Entity<T> left, Entity<T> right)
        {
            return !(left == right);
        }

        #endregion
    }
}
