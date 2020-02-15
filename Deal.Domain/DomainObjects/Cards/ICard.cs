// <copyright file="ICard.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Domain.DomainObjects.Ranks;
using Deal.Domain.DomainObjects.Suits;

namespace Deal.Domain.DomainObjects.Cards
{
    /// <summary>
    /// Card.
    /// </summary>
    public interface ICard
    {
        /// <summary>
        /// Gets the Card Id.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Gets the Suit.
        /// </summary>
        ISuit Suit { get; }

        /// <summary>
        /// Gets the Rank.
        /// </summary>
        IRank Rank { get; }
    }
}
