using Successful.Domain.Entities;

namespace Successful.Domain.Aggregates
{
    /// <summary>
    /// Interface to implement on aggregate root objects
    ///
    /// An AGGREGATE is a cluster of associated objects that we treat as a unit for the purpose of data changes.
    /// Each AGGREGATE has a root and a boundary.The boundary defines what is inside the AGGREGATE.
    /// The root is a single, specific ENTITY contained in the AGGREGATE.
    /// </summary>
    public interface IAggregateRoot : IEntity
    {
    }
}