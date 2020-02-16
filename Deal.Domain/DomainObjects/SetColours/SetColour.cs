// <copyright file="SetColour.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;

namespace Deal.Domain.DomainObjects.SetColours
{
    /// <summary>
    /// Set Colour.
    /// </summary>
    /// <seealso cref="ISetColour" />
    public class SetColour : ISetColour
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetColour"/> class.
        /// </summary>
        /// <param name="id">Set Colour Id.</param>
        /// <param name="code">Set Colour Code.</param>
        /// <param name="name">Set Colour Name.</param>
        public SetColour(
            Guid id,
            string code,
            string name)
        {
            this.Id = id;
            this.Code = code ?? throw new ArgumentNullException(nameof(code));
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        /// <inheritdoc/>
        public Guid Id { get; }

        /// <inheritdoc/>
        public string Code { get; }

        /// <inheritdoc/>
        public string Name { get; }
    }
}