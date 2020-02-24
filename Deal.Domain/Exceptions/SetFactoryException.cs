// <copyright file="SetFactoryException.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Deal.Domain.Exceptions
{
    /// <summary>
    /// SetFactoryException.
    /// </summary>
    [Serializable]
    public class SetFactoryException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetFactoryException"/> class.
        /// </summary>
        public SetFactoryException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetFactoryException"/> class.
        /// </summary>
        /// <param name="message">Message.</param>
        public SetFactoryException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetFactoryException"/> class.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="innerException">InnerException.</param>
        public SetFactoryException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetFactoryException"/> class.
        /// </summary>
        /// <param name="info">Serialization Info.</param>
        /// <param name="context">Streaming Context.</param>
        [ExcludeFromCodeCoverage]
        protected SetFactoryException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}