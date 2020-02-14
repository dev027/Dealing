// <copyright file="PackColourDto.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Deal.Data.DbContexts;

namespace Deal.Data.Dtos
{
    /// <summary>
    /// Pack Colour DTO.
    /// </summary>
    [Table(nameof(DataContext.PackColours))]
    public class PackColourDto
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PackColourDto"/> class.
        /// </summary>
        public PackColourDto()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PackColourDto"/> class.
        /// </summary>
        /// <param name="id">Pack Colour Id.</param>
        /// <param name="code">Pack Colour Code.</param>
        /// <param name="colour">Colour.</param>
        public PackColourDto(
            Guid id,
            string code,
            string colour)
        {
            this.Id = id;
            this.Code = code;
            this.Colour = colour;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the Pack Colour Id.
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Gets the Pack Colour Code.
        /// </summary>
        [Required]
        public string Code { get; private set; } = null!;

        /// <summary>
        /// Gets the Colour.
        /// </summary>
        [Required]
        public string Colour { get; private set; } = null!;

        #endregion Properties
    }
}