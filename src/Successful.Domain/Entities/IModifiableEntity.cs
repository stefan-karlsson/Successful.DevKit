using System;

namespace Successful.Domain.Entities
{
    /// <summary>
    /// Interface for modifiable entities
    /// </summary>
    public interface IModifiableEntity
    {
        /// <summary>
        /// The modification date and time for the entity
        /// </summary>
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// The user that modified the entity
        /// </summary>
        /// <example>stefan.karlsson@successful.se</example>
        public string LastModifiedBy { get; set; }
    }
}