// <copyright file="IErrorReasonGroup.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;

namespace Deal.Domain.DomainObjects.ErrorReasonGroups
{
    /// <summary>
    /// Error Reason Group.
    /// </summary>
    public interface IErrorReasonGroup
    {
        /// <summary>
        /// Gets the Error Reason GroupCode.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Gets the Error Reason GroupCode.
        /// </summary>
        string Code { get; }

        /// <summary>
        /// Gets the Error Reason Group Name.
        /// </summary>
        string Name { get; }
    }
}