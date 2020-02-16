// <copyright file="PackColourDto.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Deal.Data.DbContexts;
using Deal.Domain.DomainObjects.PackColours;

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

        #region Public Properties

        /// <summary>
        /// Converts domain object to DTO.
        /// </summary>
        /// <param name="packColour">The pack colour.</param>
        /// <returns>Pack Colour DTO.</returns>
        public static PackColourDto ToDto(IPackColour packColour)
        {
            if (packColour == null)
            {
                throw new ArgumentNullException(nameof(packColour));
            }

            return new PackColourDto(
                id: packColour.Id,
                code: packColour.Code,
                colour: packColour.Colour);
        }

        /// <summary>
        /// Converts instance to domain object.
        /// </summary>
        /// <returns>Pack Colour.</returns>
        public IPackColour ToDomain()
        {
            return new PackColour(
                id: this.Id,
                code: this.Code,
                colour: this.Colour);
        }

        #endregion Public Properties
    }
}