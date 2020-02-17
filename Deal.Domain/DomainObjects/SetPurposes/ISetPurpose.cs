// <copyright file="ISetPurpose.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;

namespace Deal.Domain.DomainObjects.SetPurposes
{
    /// <summary>
    /// Set Purpose.
    /// </summary>
    public interface ISetPurpose
    {
        /// <summary>
        /// Gets the Set Purpose Id.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Gets the Set Purpose Code.
        /// </summary>
        string Code { get; }

        /// <summary>
        /// Gets the Set Purpose Name.
        /// </summary>
        string Name { get; }
    }
}