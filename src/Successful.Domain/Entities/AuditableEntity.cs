using System;

namespace Successful.Domain.Entities
{
    /// <summary>
    /// Base class for auditable entities
    /// </summary>
    public abstract class AuditableEntity : ICreatableEntity, IModifiableEntity, IEntity
    {
        /// <inheritdoc cref="IEntity.Id"/>
        public string Id { get; set; }

        /// <inheritdoc cref="ICreatableEntity.Created"/>
        public DateTime Created { get; set; }

        /// <inheritdoc cref="ICreatableEntity.CreatedBy"/>
        public string CreatedBy { get; set; }

        /// <inheritdoc cref="IModifiableEntity.LastModified"/>
        public DateTime? LastModified { get; set; }

        /// <inheritdoc cref="IModifiableEntity.LastModifiedBy"/>
        public string LastModifiedBy { get; set; }
    }
}