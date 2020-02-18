// <copyright file="Owner.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;

namespace Deal.Domain.DomainObjects.Owners
{
    /// <summary>
    /// Owner.
    /// </summary>
    /// <seealso cref="IOwner" />
    public class Owner : IOwner
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Owner"/> class.
        /// </summary>
        /// <param name="id">Owner Id.</param>
        /// <param name="code">Owner Code.</param>
        /// <param name="name">Owner Name.</param>
        /// <param name="isClub">True if Owner is a Club.</param>
        public Owner(
            Guid id,
            string code,
            string name,
            bool isClub)
        {
            this.Id = id;
            this.Code = code ?? throw new ArgumentNullException(nameof(code));
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            this.IsClub = isClub;
        }

        /// <inheritdoc/>
        public Guid Id { get; }

        /// <inheritdoc/>
        public string Code { get; }

        /// <inheritdoc/>
        public string Name { get; }

        /// <inheritdoc />
        public bool IsClub { get; }
    }
}