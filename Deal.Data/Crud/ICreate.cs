// <copyright file="ICreate.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using Deal.Domain.DomainObjects.Cards;
using Deal.Domain.DomainObjects.PackColours;
using Deal.Domain.DomainObjects.Ranks;
using Deal.Domain.DomainObjects.Suits;

namespace Deal.Data.Crud
{
    /// <summary>
    /// Create methods.
    /// </summary>
    public interface ICreate
    {
        /// <summary>
        /// Creates the Card.
        /// </summary>
        /// <param name="card">Card.</param>
        void CreateCard(ICard card);

        /// <summary>
        /// Creates the Pack Colour.
        /// </summary>
        /// <param name="packColour">Pack Colour.</param>
        void CreatePackColour(IPackColour packColour);

        /// <summary>
        /// Creates the Suit.
        /// </summary>
        /// <param name="suit">Suit.</param>
        void CreateSuit(ISuit suit);

        /// <summary>
        /// Creates the Rank.
        /// </summary>
        /// <param name="rank">Rank.</param>
        void CreateRank(IRank rank);
    }
}