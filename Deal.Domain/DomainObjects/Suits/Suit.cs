// <copyright file="Suit.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;

namespace Deal.Domain.DomainObjects.Suits
{
    /// <summary>
    /// Suit of a Card, for example Spades.
    /// </summary>
    public class Suit : ISuit
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Suit"/> class.
        /// </summary>
        /// <param name="id">Suit Id.</param>
        /// <param name="code">Suit Code.</param>
        /// <param name="name">Suit Name.</param>
        /// <param name="sortOrder">Sort Order.</param>
        public Suit(
            Guid id,
            string code,
            string name,
            short sortOrder)
        {
            this.Id = id;
            this.Code = code ?? throw new ArgumentNullException(nameof(code));
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            this.SortOrder = sortOrder;
        }

        /// <inheritdoc/>
        public Guid Id { get; }

        /// <inheritdoc/>
        public string Code { get; }

        /// <inheritdoc/>
        public string Name { get; }

        /// <inheritdoc />
        public short SortOrder { get; }
    }
}