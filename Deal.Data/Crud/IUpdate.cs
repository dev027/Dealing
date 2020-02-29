// <copyright file="IUpdate.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using Deal.Domain.DomainObjects.Seasons;

namespace Deal.Data.Crud
{
    /// <summary>
    /// Update methods.
    /// </summary>
    public interface IUpdate
    {
        /// <summary>
        /// Updates the season.
        /// </summary>
        /// <param name="season">Season.</param>
        void UpdateSeason(ISeason season);
    }
}