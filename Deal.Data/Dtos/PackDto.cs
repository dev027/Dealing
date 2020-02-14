// <copyright file="PackDto.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations.Schema;
using Deal.Data.DbContexts;

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
    }
}