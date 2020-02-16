// <copyright file="Card.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Domain.DomainObjects.Ranks;
using Deal.Domain.DomainObjects.Suits;

namespace Deal.Domain.DomainObjects.Cards
{
    /// <summary>
    /// Cards.
    /// </summary>
    /// <seealso cref="ICard" />
    public class Card : ICard
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="id">Card Id.</param>
        /// <param name="suit">Suit.</param>
        /// <param name="rank">Rank.</param>
        public Card(
            Guid id,
            ISuit suit,
            IRank rank)
        {
            this.Id = id;
            this.Suit = suit ?? throw new ArgumentNullException(nameof(suit));
            this.Rank = rank ?? throw new ArgumentNullException(nameof(rank));
        }

        /// <inheritdoc/>
        public Guid Id { get; }

        /// <inheritdoc/>
        public ISuit Suit { get; }

        /// <inheritdoc/>
        public IRank Rank { get; }
    }
}