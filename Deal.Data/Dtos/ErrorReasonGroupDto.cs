// <copyright file="ErrorReasonGroupDto.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Deal.Data.DbContexts;

namespace Deal.Data.Dtos
{
    /// <summary>
    /// Error Reason Group DTO.
    /// </summary>
    [Table(nameof(DataContext.ErrorReasonGroups))]
    public class ErrorReasonGroupDto
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorReasonGroupDto"/> class.
        /// </summary>
        public ErrorReasonGroupDto()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorReasonGroupDto"/> class.
        /// </summary>
        /// <param name="id">Error Reason Group Id.</param>
        /// <param name="code">Error Reason Group Code.</param>
        /// <param name="name">Error Reason Group Name.</param>
        public ErrorReasonGroupDto(
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
        /// Gets the Error Reason Group Id.
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Gets the Error Reason Group .
        /// </summary>
        [Required]
        public string Code { get; private set; } = null!;

        /// <summary>
        /// Gets the Error reason Group Name.
        /// </summary>
        [Required]
        public string Name { get; private set; } = null!;

        #endregion Properties
    }
}