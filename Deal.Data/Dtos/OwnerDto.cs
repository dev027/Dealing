// <copyright file="OwnerDto.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Deal.Data.DbContexts;
using Deal.Domain.DomainObjects.Owners;

namespace Deal.Data.Dtos
{
    /// <summary>
    /// Owner DTO.
    /// </summary>
    [Table(nameof(DataContext.Owners))]
    public class OwnerDto
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OwnerDto"/> class.
        /// </summary>
        public OwnerDto()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OwnerDto"/> class.
        /// </summary>
        /// <param name="id">Owner Id.</param>
        /// <param name="code">Owner Code.</param>
        /// <param name="name">Owner Name.</param>
        /// <param name="isClub">True if Owner id a Club.</param>
        public OwnerDto(
            Guid id,
            string code,
            string name,
            bool isClub)
        {
            this.Id = id;
            this.Code = code ?? throw new ArgumentNullException(nameof(code));
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            this.IsClub = isClub;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the Owner Id.
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Gets the Owner Code.
        /// </summary>
        [Required]
        public string Code { get; private set; } = null!;

         /// <summary>
        /// Gets the Owner Name.
        /// </summary>
        [Required]
        public string Name { get; private set; } = null!;

        /// <summary>
        /// Gets a value indicating whether this instance is a club.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is club; otherwise, <c>false</c>.
        /// </value>
        public bool IsClub { get; private set; }

        #endregion Properties

        #region Public Properties

        /// <summary>
        /// Converts domain object to DTO.
        /// </summary>
        /// <param name="owner">Owner.</param>
        /// <returns>Owner DTO.</returns>
        public static OwnerDto ToDto(IOwner owner)
        {
            if (owner == null)
            {
                throw new ArgumentNullException(nameof(owner));
            }

            return new OwnerDto(
                id: owner.Id,
                code: owner.Code,
                name: owner.Name,
                isClub: owner.IsClub);
        }

        /// <summary>
        /// Converts instance to domain object.
        /// </summary>
        /// <returns>Owner.</returns>
        public IOwner ToDomain()
        {
            return new Owner(
                this.Id,
                this.Code,
                this.Name,
                this.IsClub);
        }

        #endregion
    }
}