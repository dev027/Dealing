// <copyright file="IOrganiser.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;

namespace Deal.Domain.DomainObjects.Organisers
{
    /// <summary>
    /// Organiser.
    /// </summary>
    public interface IOrganiser
    {
        /// <summary>
        /// Gets the Organiser Id.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Gets the Organiser Code.
        /// </summary>
        string Code { get; }

        /// <summary>
        /// Gets the Organiser Name.
        /// </summary>
        string Name { get; }
    }
}