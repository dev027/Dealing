// <copyright file="CardDto.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations.Schema;
using Deal.Data.DbContexts;

namespace Deal.Data.Dtos
{
    /// <summary>
    /// Card DTO.
    /// </summary>
    [Table(nameof(DataContext.Cards))]
    public class CardDto
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CardDto"/> class.
        /// </summary>
        public CardDto()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardDto"/> class.
        /// </summary>
        /// <param name="id">Card Id.</param>
        /// <param name="suitId">Suit Id.</param>
        /// <param name="rankId">Rank Id.</param>
        public CardDto(
            Guid id,
            Guid suitId,
            Guid rankId)
        {
            this.Id = id;
            this.SuitId = suitId;
            this.RankId = rankId;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the Card Id.
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Gets the Suit Id.
        /// </summary>
        public Guid SuitId { get; private set; }

        /// <summary>
        /// Gets the Rank Id.
        /// </summary>
        public Guid RankId { get; private set; }

        #endregion Properties

        #region Parent Properties

        /// <summary>
        /// Gets the Suit.
        /// </summary>
        [ForeignKey(nameof(SuitId))]
        public SuitDto? Suit { get; private set; }

        /// <summary>
        /// Gets the Rank.
        /// </summary>
        [ForeignKey(nameof(RankId))]
        public RankDto? Rank { get; private set; }

        #endregion Parent Properties
    }
}