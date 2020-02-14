// <copyright file="SuitDto.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations.Schema;
using Deal.Data.DbContexts;
using Deal.Domain.DomainObjects.Suits;

namespace Deal.Data.Dtos
{
    /// <summary>
    /// Suit DTO.
    /// </summary>
    [Table(nameof(DataContext.Suits))]
    public class SuitDto
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SuitDto"/> class.
        /// </summary>
        public SuitDto()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SuitDto"/> class.
        /// </summary>
        /// <param name="id">Suit Id.</param>
        /// <param name="code">Suit Code.</param>
        /// <param name="name">Suit Name.</param>
        /// <param name="sortOrder">Sort Order.</param>
        public SuitDto(
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
        /// Gets the Suit Id.
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Gets the Suit Code.
        /// </summary>
        public string Code { get; private set; } = null!;

        /// <summary>
        /// Gets the Suit Name.
        /// </summary>
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
        /// <param name="suit">The suit.</param>
        /// <returns>Suit DTO.</returns>
        public static SuitDto ToDto(ISuit suit)
        {
            if (suit == null)
            {
                throw new ArgumentNullException(nameof(suit));
            }

            return new SuitDto(
                id: suit.Id,
                code: suit.Code,
                name: suit.Name,
                sortOrder: suit.SortOrder);
        }

        /// <summary>
        /// Converts instance to domain object.
        /// </summary>
        /// <returns>Suit.</returns>
        public ISuit ToDomain()
        {
            return new Suit(
                id: this.Id,
                code: this.Code,
                name: this.Name,
                sortOrder: this.SortOrder);
        }

        #endregion Public Methods
    }
}