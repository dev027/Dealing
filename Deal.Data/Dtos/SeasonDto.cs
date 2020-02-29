// <copyright file="SeasonDto.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using Deal.Data.DbContexts;
using Deal.Data.Resources;
using Deal.Domain.DomainObjects.Seasons;

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

        #region Public Methods

        /// <summary>
        /// Converts domain object to DTO.
        /// </summary>
        /// <param name="season">Season.</param>
        /// <returns>Season DTO.</returns>
        public static SeasonDto ToDto(ISeason season)
        {
            if (season == null)
            {
                throw new ArgumentNullException(nameof(season));
            }

            return new SeasonDto(
                id: season.Id,
                organiserId: season.Organiser.Id,
                description: season.Description,
                startDate: season.StartDate,
                endDate: season.EndDate);
        }

        /// <summary>
        /// Converts instance to domain object.
        /// </summary>
        /// <returns>Season.</returns>
        public ISeason ToDomain()
        {
            if (this.Organiser == null)
            {
                throw new InvalidOperationException(
                    string.Format(
                        CultureInfo.InvariantCulture,
                        ExceptionResource.CannotConvertTo___If___IsNull,
                        nameof(ISeason),
                        nameof(this.Organiser)));
            }

            return new Season(
                id: this.Id,
                organiser: this.Organiser.ToDomain(),
                description: this.Description,
                startDate: this.StartDate,
                endDate: this.EndDate);
        }

        #endregion
    }
}