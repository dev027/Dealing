// <copyright file="Organiser.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;

namespace Deal.Domain.DomainObjects.Organisers
{
    /// <summary>
    /// Organiser.
    /// </summary>
    /// <seealso cref="IOrganiser" />
    public class Organiser : IOrganiser
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Organiser"/> class.
        /// </summary>
        /// <param name="id">Organiser Id.</param>
        /// <param name="code">Organiser Code.</param>
        /// <param name="name">Organiser Name.</param>
        public Organiser(
            Guid id,
            string code,
            string name)
        {
            this.Id = id;
            this.Code = code ?? throw new ArgumentNullException(nameof(code));
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        /// <inheritdoc/>
        public Guid Id { get; }

        /// <inheritdoc/>
        public string Code { get; }

        /// <inheritdoc/>
        public string Name { get; }
    }
}