// <copyright file="IErrorReason.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Domain.DomainObjects.ErrorReasonGroups;

namespace Deal.Domain.DomainObjects.ErrorReasons
{
    /// <summary>
    /// Error Reason.
    /// </summary>
    public interface IErrorReason
    {
        /// <summary>
        /// Gets the Error Reason Id.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Gets the Error Reason Code.
        /// </summary>
        string Code { get; }

        /// <summary>
        /// Gets the Error Reason Name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the Error Reason Group.
        /// </summary>
        IErrorReasonGroup ErrorReasonGroup { get; }
    }
}