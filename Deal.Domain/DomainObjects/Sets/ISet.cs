// <copyright file="ISet.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Domain.DomainObjects.Owners;
using Deal.Domain.DomainObjects.SetColours;
using Deal.Domain.DomainObjects.SetPurposes;

namespace Deal.Domain.DomainObjects.Sets
{
    /// <summary>
    /// Set.
    /// </summary>
    public interface ISet
    {
        /// <summary>
        /// Gets the Set Id.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Gets the Low Board Number.
        /// </summary>
        int LowBoardNumber { get; }

        /// <summary>
        /// Gets the High Board Number.
        /// </summary>
        int HighBoardNumber { get; }

        /// <summary>
        /// Gets the Description.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Gets the Owner.
        /// </summary>
        IOwner Owner { get; }

        /// <summary>
        /// Gets the Set Purpose.
        /// </summary>
        ISetPurpose SetPurpose { get; }

        /// <summary>
        /// Gets the Set Colour.
        /// </summary>
        ISetColour SetColour { get; }
    }
}