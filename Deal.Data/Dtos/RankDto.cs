// <copyright file="RankDto.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Deal.Data.DbContexts;
using Deal.Domain.DomainObjects.Ranks;

namespace Deal.Data.Dtos
{
    /// <summary>
    /// Rank DTO.
    /// </summary>
    [Table(nameof(DataContext.Ranks))]
    public class RankDto
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RankDto"/> class.
        /// </summary>
        public RankDto()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RankDto"/> class.
        /// </summary>
        /// <param name="id">Rank Id.</param>
        /// <param name="code">Rank Code.</param>
        /// <param name="name">Rank Name.</param>
        /// <param name="sortOrder">Sort Order.</param>
        public RankDto(
            Guid id,
            string code,
            string name,
            short sortOrder)
        {
            this.Id = id;
            this.Code = code;
            this.Name = name;
            this.SortOrder = sortOrder;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the Rank Id.
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Gets the Rank Code.
        /// </summary>
        [Required]
        public string Code { get; private set; } = null!;

        /// <summary>
        /// Gets the Rank Name.
        /// </summary>
        [Required]
        public string Name { get; private set; } = null!;

        /// <summary>
        /// Gets the Sort Order.
        /// </summary>
        public short SortOrder { get; private set; }

        #endregion Properties

        #region Public Methods

        /// <summary>
        /// Converts domain object to DTO.
        /// </summary>
        /// <param name="rank">Rank.</param>
        /// <returns>Rank DTO.</returns>
        public static RankDto ToDto(IRank rank)
        {
            if (rank == null)
            {
                throw new ArgumentNullException(nameof(rank));
            }

            return new RankDto(
                id: rank.Id,
                code: rank.Code,
                name: rank.Name,
                sortOrder: rank.SortOrder);
        }

        /// <summary>
        /// Converts instance to domain object.
        /// </summary>
        /// <returns>Rank.</returns>
        public IRank ToDomain()
        {
            return new Rank(
                id: this.Id,
                code: this.Code,
                name: this.Name,
                sortOrder: this.SortOrder);
        }

        #endregion Public Methods
    }
}