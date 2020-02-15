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
        public bool AnySuit()
        {
            return this.Context.Suits.Any();
        }

        /// <inheritdoc/>
        public bool AnyRank()
        {
            return this.Context.Ranks.Any();
        }
    }
}