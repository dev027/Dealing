// <copyright file="Pack.cs" company="Do It Wright">
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
    /// <seealso cref="IPack" />
    public class Pack : IPack
    {
        private const int MaxBoardNumber = 64;

        /// <summary>
        /// Initializes a new instance of the <see cref="Pack"/> class.
        /// </summary>
        /// <param name="id">Pack Id.</param>
        /// <param name="packColour">Pack Colour.</param>
        /// <param name="set">Set.</param>
        /// <param name="enteredService">Date the Pack Entered Service.</param>
        /// <param name="boardNumber">Board Number.</param>
        public Pack(
            Guid id,
            IPackColour packColour,
            ISet set,
            DateTime enteredService,
            int boardNumber)
        {
            this.Id = id;
            this.PackColour = packColour ?? throw new ArgumentNullException(nameof(packColour));
            this.Set = set ?? throw new ArgumentNullException(nameof(set));
            this.EnteredService = enteredService;

            if (boardNumber < 1 || boardNumber > MaxBoardNumber)
            {
                throw new ArgumentOutOfRangeException(nameof(boardNumber));
            }

            this.BoardNumber = boardNumber;
        }

        /// <inheritdoc/>
        public Guid Id { get; }

        /// <inheritdoc/>
        public IPackColour PackColour { get; }

        /// <inheritdoc/>
        public ISet Set { get; }

        /// <inheritdoc/>
        public DateTime EnteredService { get; }

        /// <inheritdoc/>
        public int BoardNumber { get; }
    }
}