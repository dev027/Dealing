// <copyright file="SetWithPacks.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using Deal.Domain.DomainObjects.Packs;

namespace Deal.Domain.DomainObjects.Sets
{
    /// <summary>
    /// Set with associated Packs.
    /// </summary>
    /// <seealso cref="Set" />
    /// <seealso cref="ISetWithPacks" />
    public class SetWithPacks : Set, ISetWithPacks
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetWithPacks"/> class.
        /// </summary>
        /// <param name="set">Set.</param>
        /// <param name="packs">List of Packs.</param>
        public SetWithPacks(
            ISet set,
            IList<IPack> packs)
            : base(set)
        {
            this.Packs = packs as IReadOnlyList<IPack> ?? throw new ArgumentNullException(nameof(packs));
        }

        /// <inheritdoc />
        public IReadOnlyList<IPack> Packs { get; }
    }
}