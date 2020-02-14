// <copyright file="SetPurposeDto.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations.Schema;
using Deal.Data.DbContexts;

namespace Deal.Data.Dtos
{
    /// <summary>
    /// Set Purpose DTO.
    /// </summary>
    [Table(nameof(DataContext.SetPurposes))]
    public class SetPurposeDto
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SetPurposeDto"/> class.
        /// </summary>
        public SetPurposeDto()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetPurposeDto"/> class.
        /// </summary>
        /// <param name="id">Set Purpose Id.</param>
        /// <param name="name">Set Purpose Name.</param>
        public SetPurposeDto(
            Guid id,
            string name)
        {
            this.Id = id;
            this.Name = name;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the Set Purpose Id.
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Gets the Set Purpose Name.
        /// </summary>
        public string Name { get; private set; } = null!;

        #endregion Properties
    }
}