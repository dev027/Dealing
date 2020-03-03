// <copyright file="PackDto.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using Deal.Data.DbContexts;
using Deal.Data.Resources;
using Deal.Domain.DomainObjects.Packs;

namespace Deal.Data.Dtos
{
    /// <summary>
    /// Pack DTO.
    /// </summary>
    [Table(nameof(DataContext.Packs))]
    public class PackDto
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PackDto"/> class.
        /// </summary>
        public PackDto()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PackDto"/> class.
        /// </summary>
        /// <param name="id">Pack Id.</param>
        /// <param name="packColourId">Pack Colour Id.</param>
        /// <param name="setId">Set Id.</param>
        /// <param name="enteredService">Date Pack Entered Service.</param>
        /// <param name="boardNumber">Board Number the Pack is currently in.</param>
        public PackDto(
            Guid id,
            Guid packColourId,
            Guid setId,
            DateTime enteredService,
            int boardNumber)
        {
            this.Id = id;
            this.PackColourId = packColourId;
            this.SetId = setId;
            this.EnteredService = enteredService;
            this.BoardNumber = boardNumber;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the Pack Id.
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Gets the Pack Colour Id.
        /// </summary>
        public Guid PackColourId { get; private set; }

        /// <summary>
        /// Gets the Set Id.
        /// </summary>
        public Guid SetId { get; private set; }

        /// <summary>
        /// Gets the Date the Pack Entered Service.
        /// </summary>
        public DateTime EnteredService { get; private set; }

        /// <summary>
        /// Gets the Board Number the Pack is currently in.
        /// </summary>
        public int BoardNumber { get; private set; }

        #endregion Properties

        #region Parent Properties

        /// <summary>
        /// Gets the Pack Colour.
        /// </summary>
        [ForeignKey(nameof(PackColourId))]
        public PackColourDto? PackColour { get; private set; }

        /// <summary>
        /// Gets the Set.
        /// </summary>
        [ForeignKey(nameof(SetId))]
        public SetDto? Set { get; private set; }

        #endregion Parent Properties

        #region Public Properties

        /// <summary>
        /// Convert domain object to DTO.
        /// </summary>
        /// <param name="pack">Pack.</param>
        /// <returns>Pack DTO.</returns>
        public static PackDto ToDto(IPack pack)
        {
            if (pack == null)
            {
                throw new ArgumentNullException(nameof(pack));
            }

            return new PackDto(
                id: pack.Id,
                packColourId: pack.PackColour.Id,
                setId: pack.Set.Id,
                enteredService: pack.EnteredService,
                boardNumber: pack.BoardNumber);
        }

        /// <summary>
        /// Convert instance to domain object.
        /// </summary>
        /// <returns>PAck.</returns>
        public IPack ToDomain()
        {
            if (this.PackColour == null)
            {
                throw new InvalidOperationException(
                    string.Format(
                        CultureInfo.InvariantCulture,
                        ExceptionResource.CannotConvertTo___If___IsNull,
                        nameof(IPack),
                        nameof(this.PackColour)));
            }

            if (this.Set == null)
            {
                throw new InvalidOperationException(
                    string.Format(
                        CultureInfo.InvariantCulture,
                        ExceptionResource.CannotConvertTo___If___IsNull,
                        nameof(IPack),
                        nameof(this.Set)));
            }

            return new Pack(
                id: this.Id,
                packColour: this.PackColour.ToDomain(),
                set: this.Set.ToDomain(),
                enteredService: this.EnteredService,
                boardNumber: this.BoardNumber);
        }

        #endregion Public Properties
    }
}