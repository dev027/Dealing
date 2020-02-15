// <copyright file="Read.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System.Collections.Generic;
using System.Linq;
using Deal.Domain.DomainObjects.Ranks;
using Deal.Domain.DomainObjects.Suits;
using Microsoft.EntityFrameworkCore;

namespace Deal.Data.Crud
{
    /// <summary>
    /// Data access layer - Read methods.
    /// </summary>
    /// <seealso cref="IDealData" />
    public partial class DealData
    {
        /// <inheritdoc/>
        public IList<ISuit> ReadAllSuits()
        {
            return this.Context.Suits
                .AsNoTracking()
                .ToList()
                .Select(s => s.ToDomain())
                .ToList();
        }

        /// <inheritdoc/>
        public IList<IRank> ReadAllRanks()
        {
            return this.Context.Ranks
                .AsNoTracking()
                .ToList()
                .Select(r => r.ToDomain())
                .ToList();
        }
    }
}