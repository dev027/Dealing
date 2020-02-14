// <copyright file="Create.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Data.Dtos;
using Deal.Domain.DomainObjects.Ranks;
using Deal.Domain.DomainObjects.Suits;
using Microsoft.EntityFrameworkCore;

namespace Deal.Data.Crud
{
    /// <summary>
    /// Data access layer - Create methods.
    /// </summary>
    /// <seealso cref="IDealData" />
    public partial class DealData
    {
        /// <summary>
        /// Create Suit.
        /// </summary>
        /// <param name="suit">Suit.</param>
        /// <exception cref="DbUpdateException">
        /// An error occurred sending updates to the database.
        /// </exception>
        /// <exception cref="DbUpdateConcurrencyException">
        /// A database command did not affect the expected number of rows.
        /// This usually indicates an optimistic concurrency violation;
        /// that is, a row has been changed in the database since it was queried.
        /// </exception>
        /// <exception cref="ApplicationException">
        /// Failed to create exactly one row.
        /// </exception>
        public void CreateSuit(ISuit suit)
        {
            SuitDto suitDto = SuitDto.ToDto(suit);
            this.Context.Suits.Add(suitDto);
            int count = this.Context.SaveChanges();

            if (count != 1)
            {
                throw new ApplicationException($"Unexpectedly created {count} rows");
            }
        }

        /// <summary>
        /// Create Rank.
        /// </summary>
        /// <param name="rank">Rank.</param>
        /// <exception cref="DbUpdateException">
        /// An error occurred sending updates to the database.
        /// </exception>
        /// <exception cref="DbUpdateConcurrencyException">
        /// A database command did not affect the expected number of rows.
        /// This usually indicates an optimistic concurrency violation;
        /// that is, a row has been changed in the database since it was queried.
        /// </exception>
        /// <exception cref="ApplicationException">
        /// Failed to create exactly one row.
        /// </exception>
        public void CreateRank(IRank rank)
        {
            RankDto rankDto = RankDto.ToDto(rank);
            this.Context.Ranks.Add(rankDto);
            int count = this.Context.SaveChanges();

            if (count != 1)
            {
                throw new ApplicationException($"Unexpectedly created {count} rows");
            }
        }
    }
}