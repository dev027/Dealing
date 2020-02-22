// <copyright file="IDealer.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;

namespace Deal.Domain.DomainObjects.Dealers
{
    /// <summary>
    /// Dealer.
    /// </summary>
    public interface IDealer
    {
        /// <summary>
        /// Gets the Dealer Id.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Gets the Dealer Name.
        /// </summary>
        string Name { get; }
    }
}