// <copyright file="SetPurposeDto.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations.Schema;
using Deal.Data.DbContexts;
using Deal.Domain.DomainObjects.SetPurposes;

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
        /// <param name="code">Set Purpose Code.</param>
        /// <param name="name">Set Purpose Name.</param>
        public SetPurposeDto(
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
        /// Gets the Set Purpose Id.
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Gets the Set Purpose Code.
        /// </summary>
        public string Code { get; private set; } = null!;

        /// <summary>
        /// Gets the Set Purpose Name.
        /// </summary>
        public string Name { get; private set; } = null!;

        #endregion Properties

        #region Public Methods

        /// <summary>
        /// Converts domain object to dto.
        /// </summary>
        /// <param name="setPurpose">Set Purpose.</param>
        /// <returns>Set Purpose DTO.</returns>
        public static SetPurposeDto ToDto(ISetPurpose setPurpose)
        {
            if (setPurpose == null)
            {
                throw new ArgumentNullException(nameof(setPurpose));
            }

            return new SetPurposeDto(
                id: setPurpose.Id,
                code: setPurpose.Code,
                name: setPurpose.Name);
        }

        /// <summary>
        /// Converts instance to domain object.
        /// </summary>
        /// <returns>Set Purpose.</returns>
        public ISetPurpose ToDomain()
        {
            return new SetPurpose(
                id: this.Id,
                code: this.Code,
                name: this.Name);
        }

        #endregion
    }
}