// <copyright file="ISeedService.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

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
        void Cards();

        /// <summary>
        /// Seeds the Error Reasons.
        /// </summary>
        void ErrorReasons();

        /// <summary>
        /// Seeds the Error Reason Groups.
        /// </summary>
        void ErrorReasonGroups();

        /// <summary>
        /// Seeds the Pack Colours.
        /// </summary>
        void PackColours();

        /// <summary>
        /// Seed the Ranks.
        /// </summary>
        void Ranks();

        /// <summary>
        /// Seed the Set Colours.
        /// </summary>
        void SetColours();

        /// <summary>
        /// Seed the Set Purposes.
        /// </summary>
        void SetPurposes();

        /// <summary>
        /// Seed the Suits.
        /// </summary>
        void Suits();
    }
}