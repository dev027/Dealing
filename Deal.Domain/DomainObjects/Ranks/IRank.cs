// <copyright file="IRank.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;

namespace Deal.Domain.DomainObjects.Ranks
{
    /// <summary>
    /// Rank of a Suit.
    /// </summary>
    public interface IRank
    {
        /// <summary>
        /// Gets the Rank Id.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Gets the Rank Code.
        /// </summary>
        string Code { get; }

        /// <summary>
        /// Gets the Rank Name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the Sort Order.
        /// </summary>
        short SortOrder { get; }
    }
}