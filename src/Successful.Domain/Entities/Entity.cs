using System.Collections.Generic;
using Successful.Domain.Events;

namespace Successful.Domain.Entities
{
    /// <inheritdoc cref="IEntity"/>
    public abstract class Entity : IEntity, IHasDomainEvent
    {
        private int? _requestedHashCode;

        protected Entity(string id)
        {
            Id = id;
        }

        /// <inheritdoc cref="IEntity.Id"/>
        public virtual string Id { get;  }

        /// <inheritdoc cref="IHasDomainEvent.DomainEvents"/>
        public List<IDomainEvent> DomainEvents { get; private set; }

        public void AddDomainEvent(IDomainEvent eventItem)
        {
            DomainEvents ??= new List<IDomainEvent>();
            DomainEvents.Add(eventItem);
        }

        public void RemoveDomainEvent(IDomainEvent eventItem)
        {
            DomainEvents?.Remove(eventItem);
        }

        public bool IsTransient()
        {
            return Id == default;
        }

        public override bool Equals(object obj)
        {
            if (obj is not Entity item)
                return false;
            if (ReferenceEquals(this, item))
                return true;
            if (GetType() != item.GetType())
                return false;
            if (item.IsTransient() || IsTransient())
                return false;
            else
                return item.Id == Id;
        }

        public override int GetHashCode()
        {
            if (!IsTransient())
            {
                _requestedHashCode ??= Id.GetHashCode() ^ 31;
                // XOR for random distribution. See:
                // https://docs.microsoft.com/archive/blogs/ericlippert/guidelines-and-rules-for-gethashcode
                return _requestedHashCode.Value;
            }
            else
                return base.GetHashCode();
        }

        public static bool operator ==(Entity left, Entity right)
        {
            return left == null ? Equals(right, null) : left.Equals(right);
        }

        public static bool operator !=(Entity left, Entity right)
        {
            return !(left == right);
        }
    }
}
