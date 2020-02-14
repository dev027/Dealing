// <copyright file="SetDealErrorDto.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations.Schema;
using Deal.Data.DbContexts;

namespace Deal.Data.Dtos
{
    /// <summary>
    /// Set Deal Errors DTO.
    /// </summary>
    [Table(nameof(DataContext.SetDealErrors))]
    public class SetDealErrorDto
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SetDealErrorDto"/> class.
        /// </summary>
        public SetDealErrorDto()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetDealErrorDto"/> class.
        /// </summary>
        /// <param name="id">Set Deal Error Id.</param>
        /// <param name="eventSetId">Event Set Id.</param>
        /// <param name="errorReasonId">Error Reason Id.</param>
        /// <param name="northCount">Count of the cards in the North hand.</param>
        /// <param name="eastCount">Count of the cards in the East hand.</param>
        /// <param name="westCount">Count of the cards in the West hand.</param>
        /// <param name="southCount">Count of the cards in the South hand.</param>
        public SetDealErrorDto(
            Guid id,
            Guid eventSetId,
            Guid errorReasonId,
            int? northCount,
            int? eastCount,
            int? westCount,
            int? southCount)
        {
            this.Id = id;
            this.EventSetId = eventSetId;
            this.ErrorReasonId = errorReasonId;
            this.NorthCount = northCount;
            this.EastCount = eastCount;
            this.WestCount = westCount;
            this.SouthCount = southCount;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the Set Deal Error Id.
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Gets the Event Set Id.
        /// </summary>
        public Guid EventSetId { get; private set; }

        /// <summary>
        /// Gets the Error Reason Id.
        /// </summary>
        public Guid ErrorReasonId { get; private set; }

        /// <summary>
        /// Gets the Count of cards in the North hand.
        /// </summary>
        public int? NorthCount { get; private set; }

        /// <summary>
        /// Gets the Count of cards in the East hand.
        /// </summary>
        public int? EastCount { get; private set; }

        /// <summary>
        /// Gets the Count of cards in the West hand.
        /// </summary>
        public int? WestCount { get; private set; }

        /// <summary>
        /// Gets the Count of cards in the South hand.
        /// </summary>
        public int? SouthCount { get; private set; }

        #endregion Properties

        #region Parent Properties

        /// <summary>
        /// Gets the event set.
        /// </summary>
        [ForeignKey(nameof(EventSetId))]
        public EventSetDto? EventSet { get; private set; }

        /// <summary>
        /// Gets the error reason.
        /// </summary>
        [ForeignKey(nameof(ErrorReasonId))]
        public ErrorReasonDto? ErrorReason { get; private set; }

        #endregion Parent Properties
    }
}