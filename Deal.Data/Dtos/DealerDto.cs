// <copyright file="DealerDto.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Deal.Data.DbContexts;

namespace Deal.Data.Dtos
{
    /// <summary>
    /// Dealer DTO.
    /// </summary>
    [Table(nameof(DataContext.Dealers))]
    public class DealerDto
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DealerDto"/> class.
        /// </summary>
        public DealerDto()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DealerDto"/> class.
        /// </summary>
        /// <param name="id">Dealer Id.</param>
        /// <param name="name">Dealer Name.</param>
        public DealerDto(
            Guid id,
            string name)
        {
            this.Id = id;
            this.Name = name;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the Dealer Id.
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Gets the Dealer Name.
        /// </summary>
        [Required]
        public string Name { get; private set; } = null!;

        #endregion Properties
    }
}