// <copyright file="SeasonDto.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Deal.Data.DbContexts;

namespace Deal.Data.Dtos
{
    /// <summary>
    /// Season DTO.
    /// </summary>
    [Table(nameof(DataContext.Seasons))]
    public class SeasonDto
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SeasonDto"/> class.
        /// </summary>
        public SeasonDto()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeasonDto"/> class.
        /// </summary>
        /// <param name="id">Season Id.</param>
        /// <param name="organiserId">Organiser Id.</param>
        /// <param name="description">Season Description.</param>
        /// <param name="startDate">Season Start Date.</param>
        /// <param name="endDate">Season End Date.</param>
        public SeasonDto(
            Guid id,
            Guid organiserId,
            string description,
            DateTime startDate,
            DateTime endDate)
        {
            this.Id = id;
            this.OrganiserId = organiserId;
            this.Description = description;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the Season Id.
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Gets the Organiser Id.
        /// </summary>
        public Guid OrganiserId { get; private set; }

        /// <summary>
        /// Gets the Season Description.
        /// </summary>
        [Required]
        public string Description { get; private set; } = null!;

        /// <summary>
        /// Gets the Season Start Date.
        /// </summary>
        public DateTime StartDate { get; private set; }

        /// <summary>
        /// Gets the Season End Date.
        /// </summary>
        public DateTime EndDate { get; private set; }

        #endregion Properties

        #region Parent Properties

        /// <summary>
        /// Gets the Organiser.
        /// </summary>
        [ForeignKey(nameof(OrganiserId))]
        public OrganiserDto? Organiser { get; private set; }

        #endregion Parent Properties
    }
}