// <copyright file="EventDto.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Deal.Data.DbContexts;

namespace Deal.Data.Dtos
{
    /// <summary>
    /// Event DTO.
    /// </summary>
    [Table(nameof(DataContext.Events))]
    public class EventDto
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="EventDto"/> class.
        /// </summary>
        public EventDto()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventDto"/> class.
        /// </summary>
        /// <param name="id">Event Id.</param>
        /// <param name="seasonId">Season Id.</param>
        /// <param name="name">Event Name.</param>
        /// <param name="subName">Event Sub-Name.</param>
        /// <param name="handCopies">Number of Hand Copies.</param>
        /// <param name="isDoubleSidedHandCopies">True if hand copies are double sided; False if single sided.</param>
        public EventDto(
            Guid id,
            Guid seasonId,
            string name,
            string subName,
            int handCopies,
            bool isDoubleSidedHandCopies)
        {
            this.Id = id;
            this.SeasonId = seasonId;
            this.Name = name;
            this.SubName = subName;
            this.HandCopies = handCopies;
            this.IsDoubleSidedHandCopies = isDoubleSidedHandCopies;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the Event Id.
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Gets the Season Id.
        /// </summary>
        public Guid SeasonId { get; private set; }

        /// <summary>
        /// Gets the Event Name.
        /// </summary>
        [Required]
        public string Name { get; private set; } = null!;

        /// <summary>
        /// Gets the Event Sub-Name.
        /// </summary>
        [Required]
        public string SubName { get; private set; } = null!;

        /// <summary>
        /// Gets the Number of Hand Copies.
        /// </summary>
        public int HandCopies { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this instance is double sided hand copies.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is double sided hand copies; otherwise, <c>false</c>.
        /// </value>
        public bool IsDoubleSidedHandCopies { get; private set; }

        #endregion Properties

        #region Parent Properties

        /// <summary>
        /// Gets the Season.
        /// </summary>
        [ForeignKey(nameof(SeasonId))]
        public SeasonDto? Season { get; private set; }

        #endregion Parent Properties
    }
}