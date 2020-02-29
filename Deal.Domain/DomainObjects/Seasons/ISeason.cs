// <copyright file="ISeason.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Domain.DomainObjects.Organisers;

namespace Deal.Domain.DomainObjects.Seasons
{
    /// <summary>
    /// Season.
    /// </summary>
    public interface ISeason
    {
        #region Public Properties

        /// <summary>
        /// Gets the Season Id.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Gets the Organiser.
        /// </summary>
        IOrganiser Organiser { get; }

        /// <summary>
        /// Gets the Season Description.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Gets the Start Date.
        /// </summary>
        DateTime StartDate { get; }

        /// <summary>
        /// Gets the End Date.
        /// </summary>
        DateTime EndDate { get; }

        #endregion

        #region Public Methods

        /// <summary>
        /// Sets the Start and End Dates.
        /// </summary>
        /// <param name="startDate">Start Date.</param>
        /// <param name="endDate">End Date.</param>
        void SetDates(
            DateTime startDate,
            DateTime endDate);

        #endregion
    }
}