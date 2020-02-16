// <copyright file="ErrorReasonGroupDto.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Deal.Data.DbContexts;
using Deal.Domain.DomainObjects.ErrorReasonGroups;

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

        #region Public Properties

        /// <summary>
        /// Converts domain object to dto.
        /// </summary>
        /// <param name="errorReasonGroup">The error reason group.</param>
        /// <returns>Error Reason Group DTO.</returns>
        public static ErrorReasonGroupDto ToDto(IErrorReasonGroup errorReasonGroup)
        {
            if (errorReasonGroup == null)
            {
                throw new ArgumentNullException(nameof(errorReasonGroup));
            }

            return new ErrorReasonGroupDto(
                id: errorReasonGroup.Id,
                code: errorReasonGroup.Code,
                name: errorReasonGroup.Name);
        }

        /// <summary>
        /// Converts this instance to domain object.
        /// </summary>
        /// <returns>Error Reason Group.</returns>
        public IErrorReasonGroup ToDomain()
        {
            return new ErrorReasonGroup(
                id: this.Id,
                code: this.Code,
                name: this.Name);
        }

        #endregion Public Properties
    }
}