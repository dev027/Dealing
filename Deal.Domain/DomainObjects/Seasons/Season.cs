// <copyright file="Season.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Domain.DomainObjects.Organisers;
using Deal.Domain.Exceptions;

namespace Deal.Domain.DomainObjects.Seasons
{
    /// <summary>
    /// Season.
    /// </summary>
    public class Season : ISeason
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Season"/> class.
        /// </summary>
        /// <param name="id">Season Id.</param>
        /// <param name="organiser">Organiser.</param>
        /// <param name="startDate">Start Date.</param>
        /// <param name="endDate">End Date.</param>
        public Season(
            Guid id,
            IOrganiser organiser,
            DateTime startDate,
            DateTime endDate)
        {
            this.Id = id;
            this.Organiser = organiser ?? throw new ArgumentNullException(nameof(organiser));

            if (startDate > endDate)
            {
                throw new StartDateAfterEndDateException(startDate, endDate);
            }

            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        /// <inheritdoc/>
        public Guid Id { get; }

        /// <inheritdoc/>
        public IOrganiser Organiser { get; }

        /// <inheritdoc/>
        public DateTime StartDate { get; }

        /// <inheritdoc/>
        public DateTime EndDate { get; }
    }
}