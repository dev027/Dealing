// <copyright file="OrganiserDto.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Deal.Data.DbContexts;
using Deal.Domain.DomainObjects.Organisers;

namespace Deal.Data.Dtos
{
    /// <summary>
    /// Organiser DTO.
    /// </summary>
    [Table(nameof(DataContext.Organisers))]
    public class OrganiserDto
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganiserDto"/> class.
        /// </summary>
        public OrganiserDto()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganiserDto"/> class.
        /// </summary>
        /// <param name="id">Organiser Id.</param>
        /// <param name="code">Organiser Code.</param>
        /// <param name="name">Organiser Name.</param>
        public OrganiserDto(
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
        /// Gets the Organiser Id.
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Gets the Organiser Code.
        /// </summary>
        [Required]
        public string Code { get; private set; } = null!;

        /// <summary>
        /// Gets the Organiser Name.
        /// </summary>
        [Required]
        public string Name { get; private set; } = null!;

        #endregion Properties

        #region Public Properties

        /// <summary>
        /// Converts domain object to DTO.
        /// </summary>
        /// <param name="organiser">The organiser.</param>
        /// <returns>Organiser DTO.</returns>
        public static OrganiserDto ToDto(IOrganiser organiser)
        {
            if (organiser == null)
            {
                throw new ArgumentNullException(nameof(organiser));
            }

            return new OrganiserDto(
                id: organiser.Id,
                code: organiser.Code,
                name: organiser.Name);
        }

        /// <summary>
        /// Converts instance to domain object.
        /// </summary>
        /// <returns>Organiser.</returns>
        public IOrganiser ToDomain()
        {
            return new Organiser(
                this.Id,
                this.Code,
                this.Name);
        }

        #endregion
    }
}