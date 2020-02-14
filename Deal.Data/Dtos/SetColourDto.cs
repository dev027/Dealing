// <copyright file="SetColourDto.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Deal.Data.DbContexts;

namespace Deal.Data.Dtos
{
    /// <summary>
    /// Set Colour DTO.
    /// </summary>
    [Table(nameof(DataContext.SetColours))]
    public class SetColourDto
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SetColourDto"/> class.
        /// </summary>
        public SetColourDto()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetColourDto"/> class.
        /// </summary>
        /// <param name="id">Set Colour DTO.</param>
        /// <param name="name">Set Colour Name.</param>
        /// <param name="code">Set Colour Code.</param>
        public SetColourDto(
            Guid id,
            string name,
            string code)
        {
            this.Id = id;
            this.Name = name;
            this.Code = code;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the Set Colour Identifier.
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Gets the Set Colour Name.
        /// </summary>
        [Required]
        public string Name { get; private set; } = null!;

        /// <summary>
        /// Gets the Set Colour Code.
        /// </summary>
        [Required]
        public string Code { get; private set; } = null!;

        #endregion Properties
    }
}