// <copyright file="IdNotNullException.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.Runtime.Serialization;

namespace Deal.Domain.Exceptions
{
    /// <summary>
    /// IdNotNullException.
    /// </summary>
    [Serializable]
    public class IdNotNullException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdNotNullException"/> class.
        /// </summary>
        public IdNotNullException()
        : base(ErrorMessage())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdNotNullException"/> class.
        /// </summary>
        /// <param name="message">Message.</param>
        public IdNotNullException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdNotNullException"/> class.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="innerException">InnerException.</param>
        public IdNotNullException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdNotNullException"/> class.
        /// </summary>
        /// <param name="info">Serialization Info.</param>
        /// <param name="context">Streaming Context.</param>
        protected IdNotNullException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        private static string ErrorMessage()
        {
            return "Cannot set Id as current Id is not null";
        }
    }
}