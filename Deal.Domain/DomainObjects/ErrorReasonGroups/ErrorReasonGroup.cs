// <copyright file="ErrorReasonGroup.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;

namespace Deal.Domain.DomainObjects.ErrorReasonGroups
{
    /// <summary>
    /// Error Reason Group.
    /// </summary>
    /// <seealso cref="IErrorReasonGroup" />
    public class ErrorReasonGroup : IErrorReasonGroup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorReasonGroup"/> class.
        /// </summary>
        /// <param name="id">Error Reason Group Id.</param>
        /// <param name="code">Error Reason Group Code.</param>
        /// <param name="name">Error Reason Group Name.</param>
        public ErrorReasonGroup(
            Guid id,
            string code,
            string name)
        {
            this.Id = id;
            this.Code = code ?? throw new ArgumentNullException(nameof(code));
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        /// <inheritdoc/>
        public Guid Id { get; }

        /// <inheritdoc/>
        public string Code { get; }

        /// <inheritdoc/>
        public string Name { get; }
    }
}