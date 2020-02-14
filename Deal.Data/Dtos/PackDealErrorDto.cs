// <copyright file="PackDealErrorDto.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations.Schema;
using Deal.Data.DbContexts;

namespace Deal.Data.Dtos
{
    /// <summary>
    /// Pack Deal Error DTo.
    /// </summary>
    [Table(nameof(DataContext.PackDealErrors))]
    public class PackDealErrorDto
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PackDealErrorDto"/> class.
        /// </summary>
        public PackDealErrorDto()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PackDealErrorDto"/> class.
        /// </summary>
        /// <param name="id">Pack Deal Error Id.</param>
        /// <param name="eventSetId">Event Set Id.</param>
        /// <param name="packId">Pack Id.</param>
        /// <param name="errorReasonId">Error Reason Id.</param>
        /// <param name="actualCardId">Actual Card Id.</param>
        /// <param name="claimedCardId">Claimed Card Id.</param>
        public PackDealErrorDto(
            Guid id,
            Guid eventSetId,
            Guid packId,
            Guid errorReasonId,
            Guid actualCardId,
            Guid? claimedCardId)
        {
            this.Id = id;
            this.EventSetId = eventSetId;
            this.PackId = packId;
            this.ErrorReasonId = errorReasonId;
            this.ActualCardId = actualCardId;
            this.ClaimedCardId = claimedCardId;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the Pack Deal Error Id.
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Gets the Event Set Identifier.
        /// </summary>
        public Guid EventSetId { get; private set; }

        /// <summary>
        /// Gets the Pack Id.
        /// </summary>
        public Guid PackId { get; private set; }

        /// <summary>
        /// Gets the Error Reason Identifier.
        /// </summary>
        public Guid ErrorReasonId { get; private set; }

        /// <summary>
        /// Gets the Actual Card Id.
        /// </summary>
        public Guid ActualCardId { get; private set; }

        /// <summary>
        /// Gets the Claimed Card Id.
        /// </summary>
        public Guid? ClaimedCardId { get; private set; }

        #endregion Properties

        #region Parent Properties

        /// <summary>
        /// Gets the Event Set.
        /// </summary>
        [ForeignKey(nameof(EventSetId))]
        public EventSetDto? EventSet { get; private set; }

        /// <summary>
        /// Gets the Pack.
        /// </summary>
        [ForeignKey(nameof(PackId))]
        public PackDto? Pack { get; private set; }

        /// <summary>
        /// Gets the Error Reason.
        /// </summary>
        [ForeignKey(nameof(ErrorReasonId))]
        public ErrorReasonDto? ErrorReason { get; private set; }

        /// <summary>
        /// Gets the Actual Card.
        /// </summary>
        [ForeignKey(nameof(ActualCardId))]
        public CardDto? ActualCard { get; private set; }

        /// <summary>
        /// Gets the Claimed Card.
        /// </summary>
        [ForeignKey(nameof(ClaimedCardId))]
        public CardDto? ClaimedCard { get; private set; }

        #endregion Parent Properties
    }
}