using System;

namespace Successful.Application.Abstractions
{
    /// <summary>
    /// Date time interface
    /// </summary>
    public interface IDateTime
    {
        /// <summary>
        /// The current date and time
        /// </summary>
        DateTime UtcNow { get; }

        /// <summary>
        /// Sets the current date and time for <see cref="UtcNow"/>
        /// </summary>
        /// <param name="dateTime">Sets the <see cref="DateTime"/> for <see cref="UtcNow"/></param>
        void Set(DateTime dateTime);

        /// <summary>
        /// Reset <see cref="UtcNow"/> to the current data and time.
        /// </summary>
        void Reset();
    }
}