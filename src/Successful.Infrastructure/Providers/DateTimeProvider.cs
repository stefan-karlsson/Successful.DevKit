using System;
using Successful.Application.Abstractions;

namespace Successful.Infrastructure.Providers
{
    public class DateTimeProvider : IDateTime
    {
        private DateTimeProvider()
        {
        }

        public DateTime UtcNow { get; private set; } = DateTime.UtcNow;

        public void Set(DateTime dateTime)
        {
            if (dateTime.Kind != DateTimeKind.Utc)
            {
                throw new ArgumentException("Date and time must be of kind UTC", nameof(dateTime));
            }

            UtcNow = dateTime;
        }

        public void Reset()
        {
            UtcNow = DateTime.UtcNow;
        }

        public override string ToString()
        {
            return UtcNow.ToString("u");
        }
    }
}
