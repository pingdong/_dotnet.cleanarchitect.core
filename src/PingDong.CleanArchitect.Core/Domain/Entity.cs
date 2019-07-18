using System.Collections.Generic;

namespace PingDong.CleanArchitect.Core
{
    public abstract class Entity<T>
    {
        #region Properties
        public virtual T Id { get; protected set; }

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

            if (object.ReferenceEquals(this, obj))
                return true;

            if (this.GetType() != obj.GetType())
                return false;

            var item = (Entity<T>)obj;

            if (item.IsTransient() || this.IsTransient())
                return false;
            
            return item.Id.Equals(this.Id);
        }

        public override int GetHashCode()
        {
            if (!IsTransient())
            {
                if (!_requestedHashCode.HasValue)
                    // XOR for random distribution (http://blogs.msdn.com/b/ericlippert/archive/2011/02/28/guidelines-and-rules-for-gethashcode.aspx)
                    _requestedHashCode = this.Id.GetHashCode() ^ 31; 

                return _requestedHashCode.Value;
            }
            
            return base.GetHashCode();
        }
        private int? _requestedHashCode;

        public static bool operator == (Entity<T> left, Entity<T> right)
        {
            if (object.Equals(left, null))
                return object.Equals(right, null) ? true : false;
            
            return left.Equals(right);
        }

        public static bool operator != (Entity<T> left, Entity<T> right)
        {
            return !(left == right);
        }
        #endregion
    }
}
