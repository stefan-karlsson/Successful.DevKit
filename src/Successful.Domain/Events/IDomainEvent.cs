using System;

namespace Successful.Domain.Events
{
    /// <summary>
    /// Interface to inherit when creating a domain event
    /// </summary>
    public interface IDomainEvent
    {
        /// <summary>
        /// Gets or sets if the <see cref="IDomainEvent"/> is published or not
        /// </summary>
        public bool IsPublished { get; set; }

        /// <summary>
        /// Gets the date and time when the <see cref="IDomainEvent"/> occurred
        /// </summary>
        public DateTimeOffset Occurred { get; }
    }
}