// <copyright file="ErrorReason.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Domain.DomainObjects.ErrorReasonGroups;

namespace Deal.Domain.DomainObjects.ErrorReasons
{
    /// <summary>
    /// Error Reason.
    /// </summary>
    /// <seealso cref="IErrorReason" />
    public class ErrorReason : IErrorReason
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorReason"/> class.
        /// </summary>
        /// <param name="id">Error Reason Id.</param>
        /// <param name="code">Error Reason Code.</param>
        /// <param name="name">Error Reason Name.</param>
        /// <param name="errorReasonGroup">Error Reason  Group.</param>
        public ErrorReason(
            Guid id,
            string code,
            string name,
            IErrorReasonGroup errorReasonGroup)
        {
            this.Id = id;
            this.Code = code ?? throw new ArgumentNullException(nameof(code));
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            this.ErrorReasonGroup = errorReasonGroup ?? throw new ArgumentNullException(nameof(errorReasonGroup));
        }

        /// <inheritdoc/>
        public Guid Id { get; }

        /// <inheritdoc/>
        public string Code { get; }

        /// <inheritdoc/>
        public string Name { get; }

        /// <inheritdoc/>
        public IErrorReasonGroup ErrorReasonGroup { get; }
    }
}