// <copyright file="ISetColour.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;

namespace Deal.Domain.DomainObjects.SetColours
{
    /// <summary>
    /// Set Colour.
    /// </summary>
    public interface ISetColour
    {
        /// <summary>
        /// Gets the Ste Colour Id.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Gets the Set Colour Code.
        /// </summary>
        string Code { get; }

        /// <summary>
        /// Gets the Set Colour Name.
        /// </summary>
        string Name { get; }
    }
}