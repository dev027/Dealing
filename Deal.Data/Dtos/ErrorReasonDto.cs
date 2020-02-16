// <copyright file="ErrorReasonDto.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Deal.Data.DbContexts;

namespace Deal.Data.Dtos
{
    /// <summary>
    /// Error Reason DTO.
    /// </summary>
    [Table(nameof(DataContext.ErrorReasons))]
    public class ErrorReasonDto
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorReasonDto"/> class.
        /// </summary>
        public ErrorReasonDto()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorReasonDto"/> class.
        /// </summary>
        /// <param name="id">Error Reason Id.</param>
        /// <param name="code">Error Reason Code.</param>
        /// <param name="name">Error Reason Name.</param>
        public ErrorReasonDto(
             Guid id,
             string code,
             string name)
        {
            this.Id = id;
            this.Name = name;
            this.Code = code;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the Error Reason Id.
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Gets the Error Reason Code.
        /// </summary>
        [Required]
        public string Code { get; private set; } = null!;

        /// <summary>
        /// Gets the Error Reason Name.
        /// </summary>
        [Required]
        public string Name { get; private set; } = null!;

        /// <summary>
        /// Gets the Error Reason Group Id.
        /// </summary>
        public Guid ErrorReasonGroupId { get; private set; }

        #endregion Properties

        #region Parent Properties

        /// <summary>
        /// Gets the Error Reason Group.
        /// </summary>
        [ForeignKey(nameof(ErrorReasonGroupId))]
        public ErrorReasonGroupDto? ErrorReasonGroup { get; private set; }

        #endregion Parent Properties
    }
}