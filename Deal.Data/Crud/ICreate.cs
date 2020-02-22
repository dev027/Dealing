// <copyright file="ICreate.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using Deal.Domain.DomainObjects.Cards;
using Deal.Domain.DomainObjects.ErrorReasonGroups;
using Deal.Domain.DomainObjects.ErrorReasons;
using Deal.Domain.DomainObjects.Owners;
using Deal.Domain.DomainObjects.PackColours;
using Deal.Domain.DomainObjects.Ranks;
using Deal.Domain.DomainObjects.SetColours;
using Deal.Domain.DomainObjects.SetPurposes;
using Deal.Domain.DomainObjects.Sets;
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
        /// Creates the Error Reason.
        /// </summary>
        /// <param name="errorReason">Error Reason.</param>
        void CreateErrorReason(IErrorReason errorReason);

        /// <summary>
        /// Creates the Error Reason Group.
        /// </summary>
        /// <param name="errorReasonGroup">Error Reason Group.</param>
        void CreateErrorReasonGroup(IErrorReasonGroup errorReasonGroup);

        /// <summary>
        /// Creates the Owner.
        /// </summary>
        /// <param name="owner">Owner.</param>
        void CreateOwner(IOwner owner);

        /// <summary>
        /// Creates the Rank.
        /// </summary>
        /// <param name="rank">Rank.</param>
        void CreateRank(IRank rank);

        /// <summary>
        /// Creates the Set.
        /// </summary>
        /// <param name="set">Set.</param>
        void CreateSet(ISet set);

        /// <summary>
        /// Creates the Set Colour.
        /// </summary>
        /// <param name="setColour">Set Colour.</param>
        void CreateSetColour(ISetColour setColour);

        /// <summary>
        /// Creates the Set Purpose.
        /// </summary>
        /// <param name="setPurpose">Set Purpose.</param>
        void CreateSetPurpose(ISetPurpose setPurpose);

        /// <summary>
        /// Creates the Suit.
        /// </summary>
        /// <param name="suit">Suit.</param>
        void CreateSuit(ISuit suit);
    }
}