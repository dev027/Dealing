// <copyright file="IPackColour.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;

namespace Deal.Domain.DomainObjects.PackColours
{
    /// <summary>
    /// Pack Colour.
    /// </summary>
    public interface IPackColour
    {
        /// <summary>
        /// Gets the Pack Colour Id.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Gets the Pack Colour Code.
        /// </summary>
        string Code { get; }

        /// <summary>
        /// Gets the Colour.
        /// </summary>
        string Colour { get; }
    }
}