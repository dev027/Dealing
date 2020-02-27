using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Deal.Domain.Exceptions
{
    /// <summary>
    /// StartDateAfterEndDateException.
    /// </summary>
    [Serializable]
    public class StartDateAfterEndDateException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StartDateAfterEndDateException"/> class.
        /// </summary>
        /// <param name="startDate">Start date.</param>
        /// <param name="endDate">End date.</param>
        public StartDateAfterEndDateException(
            DateTime startDate,
            DateTime endDate)
        : base(FormatErrorMessage(startDate, endDate))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartDateAfterEndDateException"/> class.
        /// </summary>
        [ExcludeFromCodeCoverage]
        public StartDateAfterEndDateException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartDateAfterEndDateException"/> class.
        /// </summary>
        /// <param name="message">Message.</param>
        [ExcludeFromCodeCoverage]
        public StartDateAfterEndDateException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartDateAfterEndDateException"/> class.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="innerException">InnerException.</param>
        [ExcludeFromCodeCoverage]
        public StartDateAfterEndDateException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartDateAfterEndDateException"/> class.
        /// </summary>
        /// <param name="info">Serialization Info.</param>
        /// <param name="context">Streaming Context.</param>
        [ExcludeFromCodeCoverage]
        protected StartDateAfterEndDateException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        private static string FormatErrorMessage(DateTime startDate, DateTime endDate)
        {
            return $"The StartDate '{startDate}' is AFTER the EndDate '{endDate}'.";
        }
    }
}