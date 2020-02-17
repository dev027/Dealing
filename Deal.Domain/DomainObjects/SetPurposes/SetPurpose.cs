// <copyright file="SetPurpose.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;

namespace Deal.Domain.DomainObjects.SetPurposes
{
    /// <summary>
    /// Set Purpose.
    /// </summary>
    /// <seealso cref="Deal.Domain.DomainObjects.SetPurposes.ISetPurpose" />
    public class SetPurpose : ISetPurpose
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetPurpose"/> class.
        /// </summary>
        /// <param name="id">Set Purpose Id.</param>
        /// <param name="code">Set Purpose Code.</param>
        /// <param name="name">Set Purpose Name.</param>
        public SetPurpose(
            Guid id,
            string code,
            string name)
        {
            this.Id = id;
            this.Code = code ?? throw new ArgumentNullException(nameof(code));
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        /// <inheritdoc />
        public Guid Id { get; }

        /// <inheritdoc />
        public string Code { get; }

        /// <inheritdoc />
        public string Name { get; }
    }
}