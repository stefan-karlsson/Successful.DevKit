using System.Collections.Generic;

namespace Successful.Domain.Events
{
    /// <summary>
    /// Interface to inherit when a domain object has domain events
    /// </summary>
    public interface IHasDomainEvent
    {
        /// <summary>
        /// The domain events
        /// </summary>
        public List<IDomainEvent> DomainEvents { get; }

        /// <summary>
        /// Adding a new domain event
        /// </summary>
        /// <param name="domainEvent">The domain event to add</param>
        void AddDomainEvent(IDomainEvent domainEvent);

        /// <summary>
        /// Removing a existing domain event
        /// </summary>
        /// <param name="domainEvent">The domain event to remove</param>
        void RemoveDomainEvent(IDomainEvent domainEvent);
    }
}