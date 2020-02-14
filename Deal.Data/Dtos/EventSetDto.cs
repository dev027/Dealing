// <copyright file="EventSetDto.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations.Schema;
using Deal.Data.DbContexts;

namespace Deal.Data.Dtos
{
    /// <summary>
    /// Event Set DTO.
    /// </summary>
    [Table(nameof(DataContext.EventSets))]
    public class EventSetDto
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="EventSetDto"/> class.
        /// </summary>
        public EventSetDto()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventSetDto"/> class.
        /// </summary>
        /// <param name="id">Event Set Id.</param>
        /// <param name="eventId">Event Id.</param>
        /// <param name="setId">Set Id.</param>
        /// <param name="dealerId">Dealer Id.</param>
        /// <param name="dealt">Date set was dealt.</param>
        /// <param name="isBoardsReturnedOutOfSequence">True if boards returned were out of sequence.</param>
        public EventSetDto(
            Guid id,
            Guid eventId,
            Guid setId,
            Guid dealerId,
            DateTime dealt,
            bool isBoardsReturnedOutOfSequence)
        {
            this.Id = id;
            this.EventId = eventId;
            this.SetId = setId;
            this.DealerId = dealerId;
            this.Dealt = dealt;
            this.IsBoardsReturnedOutOfSequence = isBoardsReturnedOutOfSequence;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the Event Set Id.
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Gets the Event Id.
        /// </summary>
        public Guid EventId { get; private set; }

        /// <summary>
        /// Gets the Set Id.
        /// </summary>
        public Guid SetId { get; private set; }

        /// <summary>
        /// Gets the dealer identifier.
        /// </summary>
        /// <value>
        /// The dealer identifier.
        /// </value>
        public Guid DealerId { get; private set; }

        /// <summary>
        /// Gets the Date the boards were Dealt.
        /// </summary>
        public DateTime Dealt { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this instance is boards returned out of sequence.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is boards returned out of sequence; otherwise, <c>false</c>.
        /// </value>
        public bool IsBoardsReturnedOutOfSequence { get; private set; }

        #endregion Properties

        #region Parent Properties

        /// <summary>
        /// Gets the Event.
        /// </summary>
        [ForeignKey(nameof(EventId))]
        public EventDto? Event { get; private set; }

        /// <summary>
        /// Gets the Set.
        /// </summary>
        [ForeignKey(nameof(SetId))]
        public SetDto? Set { get; private set; }

        /// <summary>
        /// Gets the Dealer.
        /// </summary>
        [ForeignKey(nameof(DealerId))]
        public DealerDto? Dealer { get; private set; }

        #endregion Parent Properties
    }
}