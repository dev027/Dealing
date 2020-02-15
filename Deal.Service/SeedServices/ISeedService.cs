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
        /// Seed the Ranks.
        /// </summary>
        void Ranks();

        /// <summary>
        /// Seed the Suits.
        /// </summary>
        void Suits();
    }
}