// <copyright file="Rank.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;

namespace Deal.Domain.DomainObjects.Ranks
{
    /// <summary>
    /// Rank of a card, for example King.
    /// </summary>
    public class Rank : IRank
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rank"/> class.
        /// </summary>
        /// <param name="id">Rank Id.</param>
        /// <param name="code">Rank Code.</param>
        /// <param name="name">Rank Name.</param>
        /// <param name="sortOrder">Sort Order.</param>
        public Rank(
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

        /// <inheritdoc/>
        public short SortOrder { get; }
    }
}