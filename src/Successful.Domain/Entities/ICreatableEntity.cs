using System;

namespace Successful.Domain.Entities
{
    /// <summary>
    /// Interface for creatable entities
    /// </summary>
    public interface ICreatableEntity
    {
        /// <summary>
        /// The creation date and time for the entity
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// The user that created the entity
        /// </summary>
        /// <example>stefan.karlsson@successful.se</example>
        public string CreatedBy { get; set; }
    }
}
