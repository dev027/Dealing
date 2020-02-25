// <copyright file="OrganiserDto.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Deal.Data.DbContexts;

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
    }
}