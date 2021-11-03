using System;

namespace Successful.Domain.Events
{
    /// <summary>
    /// Abstract class to inherit when creating a domain event
    /// </summary>
    public abstract class DomainEvent : IDomainEvent
    {
        protected DomainEvent(DateTimeOffset occurred)
        {
            Occurred = occurred;
        }

        /// <inheritdoc cref="IDomainEvent.IsPublished"/>
        public bool IsPublished { get; set; }

        /// <inheritdoc cref="IDomainEvent.Occurred"/>
        public DateTimeOffset Occurred { get; protected set; }
    }
}