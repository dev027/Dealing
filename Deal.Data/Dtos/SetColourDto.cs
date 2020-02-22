// <copyright file="SetColourDto.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Deal.Data.DbContexts;
using Deal.Domain.DomainObjects.SetColours;

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
        /// <param name="code">Set Colour Code.</param>
        /// <param name="name">Set Colour Name.</param>
        public SetColourDto(
            Guid id,
            string code,
            string name)
        {
            this.Id = id;
            this.Code = code;
            this.Name = name;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the Set Colour Identifier.
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Gets the Set Colour Code.
        /// </summary>
        [Required]
        public string Code { get; private set; } = null!;

        /// <summary>
        /// Gets the Set Colour Name.
        /// </summary>
        [Required]
        public string Name { get; private set; } = null!;

        #endregion Properties

        #region Public Methods

        /// <summary>
        /// Converts domain object to DTO.
        /// </summary>
        /// <param name="setColour">The set colour.</param>
        /// <returns>Set Colour.</returns>
        public static SetColourDto ToDto(ISetColour setColour)
        {
            if (setColour == null)
            {
                throw new ArgumentNullException(nameof(setColour));
            }

            return new SetColourDto(
                id: setColour.Id,
                code: setColour.Code,
                name: setColour.Name);
        }

        /// <summary>
        /// Converts instance to domain object.
        /// </summary>
        /// <returns>Set Colour.</returns>
        public ISetColour ToDomain()
        {
            return new SetColour(
                id: this.Id,
                code: this.Code,
                name: this.Name);
        }

        #endregion Public Methods
    }
}