// <copyright file="ISuit.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;

namespace Deal.Domain.DomainObjects.Suits
{
    /// <summary>
    /// Suit of a Card.
    /// </summary>
    public interface ISuit
    {
        /// <summary>
        /// Gets the Suit Id.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Gets the Suit Code.
        /// </summary>
        string Code { get; }

        /// <summary>
        /// Gets the Suit Name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the Sort Order.
        /// </summary>
        short SortOrder { get; }
    }
}