// <copyright file="ISeedService.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using DoItWright.Library.Logging;

namespace Deal.Service.SeedServices
{
    /// <summary>
    /// Seed Service.
    /// </summary>
    public interface ISeedService
    {
        /// <summary>
        /// Seeds the Cards.
        /// </summary>
        /// <param name="caller">Caller.</param>
        void Cards(ICaller caller);

        /// <summary>
        /// Seeds the Dealers.
        /// </summary>
        /// <param name="caller">Caller.</param>
        void Dealers(ICaller caller);

        /// <summary>
        /// Seeds the Error Reasons.
        /// </summary>
        /// <param name="caller">Caller.</param>
        void ErrorReasons(ICaller caller);

        /// <summary>
        /// Seeds the Error Reason Groups.
        /// </summary>
        /// <param name="caller">Caller.</param>
        void ErrorReasonGroups(ICaller caller);

        /// <summary>
        /// Seeds the Organisers.
        /// </summary>
        /// <param name="caller">Caller.</param>
        void Organisers(ICaller caller);

        /// <summary>
        /// Seeds the Owners.
        /// </summary>
        /// <param name="caller">Caller.</param>
        void Owners(ICaller caller);

        /// <summary>
        /// Seeds the Pack Colours.
        /// </summary>
        /// <param name="caller">Caller.</param>
        void PackColours(ICaller caller);

        /// <summary>
        /// Seed the Ranks.
        /// </summary>
        /// <param name="caller">Caller.</param>
        void Ranks(ICaller caller);

        /// <summary>
        /// Seeds the Sets.
        /// </summary>
        /// <param name="caller">Caller.</param>
        void Sets(ICaller caller);

        /// <summary>
        /// Seed the Set Colours.
        /// </summary>
        /// <param name="caller">Caller.</param>
        void SetColours(ICaller caller);

        /// <summary>
        /// Seed the Set Purposes.
        /// </summary>
        /// <param name="caller">Caller.</param>
        void SetPurposes(ICaller caller);

        /// <summary>
        /// Seed the Suits.
        /// </summary>
        /// <param name="caller">Caller.</param>
        void Suits(ICaller caller);
    }
}