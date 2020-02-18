// <copyright file="IOwner.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;

namespace Deal.Domain.DomainObjects.Owners
{
    /// <summary>
    /// Owner.
    /// </summary>
    public interface IOwner
    {
        /// <summary>
        /// Gets the Owner Id.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Gets the Owner Code.
        /// </summary>
        string Code { get; }

        /// <summary>
        /// Gets the Owner Name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets a value indicating whether this instance is a Club.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is a Club; otherwise, <c>false</c>.
        /// </value>
        bool IsClub { get; }
    }
}