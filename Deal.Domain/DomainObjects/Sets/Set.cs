// <copyright file="Set.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Domain.DomainObjects.Owners;
using Deal.Domain.DomainObjects.SetColours;
using Deal.Domain.DomainObjects.SetPurposes;
using Deal.Domain.Resources;

namespace Deal.Domain.DomainObjects.Sets
{
    /// <summary>
    /// Set.
    /// </summary>
    /// <seealso cref="ISet" />
    public class Set : ISet
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Set"/> class.
        /// </summary>
        /// <param name="set">Set.</param>
        public Set(ISet set)
        {
            if (set == null)
            {
                throw new ArgumentNullException(nameof(set));
            }

            this.Id = set.Id;
            this.LowBoardNumber = set.LowBoardNumber;
            this.HighBoardNumber = set.HighBoardNumber;
            this.Description = set.Description;
            this.Owner = set.Owner;
            this.SetPurpose = set.SetPurpose;
            this.SetColour = set.SetColour;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Set"/> class.
        /// </summary>
        /// <param name="id">Set Id.</param>
        /// <param name="lowBoardNumber">Low Board Number.</param>
        /// <param name="highBoardNumber">High Board Number.</param>
        /// <param name="description">Description.</param>
        /// <param name="owner">Owner.</param>
        /// <param name="setPurpose">Set Purpose.</param>
        /// <param name="setColour">Set Colour.</param>
        public Set(
            Guid id,
            int lowBoardNumber,
            int highBoardNumber,
            string description,
            IOwner owner,
            ISetPurpose setPurpose,
            ISetColour setColour)
        {
            if (lowBoardNumber < 1)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(lowBoardNumber),
                    ExceptionResource.LowBoardNumberShouldBeAtLeastOne);
            }

            if (lowBoardNumber > highBoardNumber)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(lowBoardNumber),
                    ExceptionResource.LowBoardNumberShouldNotBeHigherThanHighBoardNumber);
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentNullException(nameof(description));
            }

            this.Id = id;
            this.LowBoardNumber = lowBoardNumber;
            this.HighBoardNumber = highBoardNumber;
            this.Description = description;
            this.Owner = owner ?? throw new ArgumentNullException(nameof(owner));
            this.SetPurpose = setPurpose ?? throw new ArgumentNullException(nameof(setPurpose));
            this.SetColour = setColour ?? throw new ArgumentNullException(nameof(setColour));
        }

        #endregion Constructors

        /// <inheritdoc/>
        public Guid Id { get; }

        /// <inheritdoc/>
        public int LowBoardNumber { get; }

        /// <inheritdoc/>
        public int HighBoardNumber { get; }

        /// <inheritdoc/>
        public string Description { get; }

        /// <inheritdoc/>
        public IOwner Owner { get; }

        /// <inheritdoc/>
        public ISetPurpose SetPurpose { get; }

        /// <inheritdoc/>
        public ISetColour SetColour { get; }
    }
}