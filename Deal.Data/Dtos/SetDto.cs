// <copyright file="SetDto.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using Deal.Data.DbContexts;
using Deal.Data.Resources;
using Deal.Domain.DomainObjects.Sets;

namespace Deal.Data.Dtos
{
    /// <summary>
    /// Set DTO.
    /// </summary>
    [Table(nameof(DataContext.Sets))]
    public class SetDto
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SetDto"/> class.
        /// </summary>
        public SetDto()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetDto"/> class.
        /// </summary>
        /// <param name="id">Set Id.</param>
        /// <param name="ownerId">Owner Id.</param>
        /// <param name="setPurposeId">Set Purpose Id.</param>
        /// <param name="setColourId">Set Colour Id.</param>
        /// <param name="lowBoardNumber">Low Board Number.</param>
        /// <param name="highBoardNumber">High Board Number.</param>
        /// <param name="description">Set Description.</param>
        public SetDto(
            Guid id,
            Guid ownerId,
            Guid setPurposeId,
            Guid setColourId,
            int lowBoardNumber,
            int highBoardNumber,
            string description)
        {
            this.Id = id;
            this.OwnerId = ownerId;
            this.SetPurposeId = setPurposeId;
            this.SetColourId = setColourId;
            this.LowBoardNumber = lowBoardNumber;
            this.HighBoardNumber = highBoardNumber;
            this.Description = description;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the Set Id.
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Gets the Owner Id.
        /// </summary>
        public Guid OwnerId { get; private set; }

        /// <summary>
        /// Gets the Set Purpose Id.
        /// </summary>
        public Guid SetPurposeId { get; private set; }

        /// <summary>
        /// Gets the set colour identifier.
        /// </summary>
        public Guid SetColourId { get; private set; }

        /// <summary>
        /// Gets the Low Board Number.
        /// </summary>
        public int LowBoardNumber { get; private set; }

        /// <summary>
        /// Gets the High Board Number.
        /// </summary>
        public int HighBoardNumber { get; private set; }

        /// <summary>
        /// Gets the Set Description.
        /// </summary>
        [Required]
        public string Description { get; private set; } = null!;

        #endregion Properties

        #region Parent Properties

        /// <summary>
        /// Gets the Owner.
        /// </summary>
        [ForeignKey(nameof(OwnerId))]
        public OwnerDto? Owner { get; private set; }

        /// <summary>
        /// Gets the Set Purpose.
        /// </summary>
        [ForeignKey(nameof(SetPurposeId))]
        public SetPurposeDto? SetPurpose { get; private set; }

        /// <summary>
        /// Gets the Set Colour.
        /// </summary>
        [ForeignKey(nameof(SetColourId))]
        public SetColourDto? SetColour { get; private set; }

        #endregion Parent Properties

        #region Public Methods

        /// <summary>
        /// Converts domain object to DTO.
        /// </summary>
        /// <param name="set">Set.</param>
        /// <returns>Set DTO.</returns>
        public static SetDto ToDto(ISet set)
        {
            if (set == null)
            {
                throw new ArgumentNullException(nameof(set));
            }

            return new SetDto(
                id: set.Id,
                ownerId: set.Owner.Id,
                setPurposeId: set.SetPurpose.Id,
                setColourId: set.SetColour.Id,
                lowBoardNumber: set.LowBoardNumber,
                highBoardNumber: set.HighBoardNumber,
                description: set.Description);
        }

        /// <summary>
        /// Converts instance to domain object.
        /// </summary>
        /// <returns>Set.</returns>
        public ISet ToDomain()
        {
            if (this.Owner == null)
            {
                throw new InvalidOperationException(
                    string.Format(
                        CultureInfo.InvariantCulture,
                        ExceptionResource.CannotConvertTo___If___IsNull,
                        nameof(ISet),
                        nameof(this.Owner)));
            }

            if (this.SetPurpose == null)
            {
                throw new InvalidOperationException(
                    string.Format(
                        CultureInfo.InvariantCulture,
                        ExceptionResource.CannotConvertTo___If___IsNull,
                        nameof(ISet),
                        nameof(this.SetPurpose)));
            }

            if (this.SetColour == null)
            {
                throw new InvalidOperationException(
                    string.Format(
                        CultureInfo.InvariantCulture,
                        ExceptionResource.CannotConvertTo___If___IsNull,
                        nameof(ISet),
                        nameof(this.SetColour)));
            }

            return new Set(
                id: this.Id,
                lowBoardNumber: this.LowBoardNumber,
                highBoardNumber: this.HighBoardNumber,
                description: this.Description,
                owner: this.Owner.ToDomain(),
                setPurpose: this.SetPurpose.ToDomain(),
                setColour: this.SetColour.ToDomain());
        }

        #endregion
    }
}