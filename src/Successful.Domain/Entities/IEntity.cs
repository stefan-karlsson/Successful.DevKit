namespace Successful.Domain.Entities
{
    /// <summary>
    /// Interface to implement on all entity objects
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Unique identifier of the entity.
        /// </summary>
        public string Id { get; }
    }
}
