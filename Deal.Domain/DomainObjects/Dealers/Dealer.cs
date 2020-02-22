// <copyright file="Dealer.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;

namespace Deal.Domain.DomainObjects.Dealers
{
    /// <summary>
    /// Dealer.
    /// </summary>
    /// <seealso cref="IDealer" />
    public class Dealer : IDealer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dealer"/> class.
        /// </summary>
        /// <param name="id">Dealer id.</param>
        /// <param name="name">Dealer Name.</param>
        public Dealer(Guid id, string name)
        {
            this.Id = id;
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        /// <inheritdoc/>
        public Guid Id { get; }

        /// <inheritdoc/>
        public string Name { get; }
    }
}