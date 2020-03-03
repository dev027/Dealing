// <copyright file="ISetWithPacks.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System.Collections.Generic;
using Deal.Domain.DomainObjects.Packs;

namespace Deal.Domain.DomainObjects.Sets
{
    /// <summary>
    /// Set with associated Packs.
    /// </summary>
    /// <seealso cref="ISet" />
    public interface ISetWithPacks : ISet
    {
        /// <summary>
        /// Gets the Packs associated with this Set.
        /// </summary>
        IReadOnlyList<IPack> Packs { get; }
    }
}