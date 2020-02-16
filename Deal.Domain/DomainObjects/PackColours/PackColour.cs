// <copyright file="PackColour.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;

namespace Deal.Domain.DomainObjects.PackColours
{
    /// <summary>
    /// Pack Colour.
    /// </summary>
    /// <seealso cref="Deal.Domain.DomainObjects.PackColours.IPackColour" />
    public class PackColour : IPackColour
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PackColour"/> class.
        /// </summary>
        /// <param name="id">Pack Colour Id.</param>
        /// <param name="code">Pack Colour Code.</param>
        /// <param name="colour">Colour.</param>
        public PackColour(Guid id, string code, string colour)
        {
            this.Id = id;
            this.Code = code ?? throw new ArgumentNullException(nameof(code));
            this.Colour = colour ?? throw new ArgumentNullException(nameof(colour));
        }

        /// <inheritdoc/>
        public Guid Id { get; }

        /// <inheritdoc/>
        public string Code { get; }

        /// <inheritdoc/>
        public string Colour { get; }
    }
}