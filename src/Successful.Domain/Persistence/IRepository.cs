using Successful.Domain.Aggregates;

namespace Successful.Domain.Persistence
{
    /// <summary>
    /// Interface to inherit when creating a Repository
    /// </summary>
    /// <typeparam name="T">The aggregate root</typeparam>
    public interface IRepository<T> where T : IAggregateRoot
    {
        /// <summary>
        /// The unit that does the work
        /// </summary>
        IUnitOfWork UnitOfWork { get; }
    }
}