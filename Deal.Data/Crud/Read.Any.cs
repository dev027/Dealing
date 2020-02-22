// <copyright file="Read.Any.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System.Linq;

namespace Deal.Data.Crud
{
    /// <summary>
    /// Check if tables have rows.
    /// </summary>
    /// <seealso cref="IDealData" />
    public partial class DealData
    {
        /// <inheritdoc/>
        public bool AnyCard()
        {
            return this.Context.Cards.Any();
        }

        /// <inheritdoc/>
        public bool AnyErrorReason()
        {
            return this.Context.ErrorReasons.Any();
        }

        /// <inheritdoc />
        public bool AnyErrorReasonGroup()
        {
            return this.Context.ErrorReasonGroups.Any();
        }

        /// <inheritdoc />
        public bool AnyOwner()
        {
            return this.Context.Owners.Any();
        }

        /// <inheritdoc/>
        public bool AnyPackColour()
        {
            return this.Context.PackColours.Any();
        }

        /// <inheritdoc/>
        public bool AnyRank()
        {
            return this.Context.Ranks.Any();
        }

        /// <inheritdoc />
        public bool AnySets()
        {
            return this.Context.Sets.Any();
        }

        /// <inheritdoc/>
        public bool AnySetColours()
        {
            return this.Context.SetColours.Any();
        }

        /// <inheritdoc/>
        public bool AnySetPurpose()
        {
            return this.Context.SetPurposes.Any();
        }

        /// <inheritdoc/>
        public bool AnySuit()
        {
            return this.Context.Suits.Any();
        }
    }
}