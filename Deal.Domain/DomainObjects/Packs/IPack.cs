// <copyright file="IPack.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Domain.DomainObjects.PackColours;
using Deal.Domain.DomainObjects.Sets;

namespace Deal.Domain.DomainObjects.Packs
{
    /// <summary>
    /// Pack.
    /// </summary>
    public interface IPack
    {
        /// <summary>
        /// Gets the Pack Id.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Gets the Pack Colour.
        /// </summary>
        IPackColour PackColour { get; }

        /// <summary>
        /// Gets the Set.
        /// </summary>
        ISet Set { get; }

        /// <summary>
        /// Gets the Date the Pack Entered Service.
        /// </summary>
        DateTime EnteredService { get; }

        /// <summary>
        /// Gets the Board Number.
        /// </summary>
        int BoardNumber { get; }
    }
}
