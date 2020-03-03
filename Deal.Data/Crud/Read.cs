// <copyright file="Read.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System.Collections.Generic;
using System.Linq;
using Deal.Domain.DomainObjects.Dealers;
using Deal.Domain.DomainObjects.ErrorReasonGroups;
using Deal.Domain.DomainObjects.Organisers;
using Deal.Domain.DomainObjects.Owners;
using Deal.Domain.DomainObjects.PackColours;
using Deal.Domain.DomainObjects.Ranks;
using Deal.Domain.DomainObjects.Seasons;
using Deal.Domain.DomainObjects.SetColours;
using Deal.Domain.DomainObjects.SetPurposes;
using Deal.Domain.DomainObjects.Sets;
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
        public IList<IDealer> ReadAllDealers()
        {
            return this.Context.Dealers
                .AsNoTracking()
                .ToList()
                .Select(d => d.ToDomain())
                .ToList();
        }

        /// <inheritdoc/>
        public IList<IErrorReasonGroup> ReadAllErrorReasonGroups()
        {
            return this.Context.ErrorReasonGroups
                .AsNoTracking()
                .ToList()
                .Select(erg => erg.ToDomain())
                .ToList();
        }

        /// <inheritdoc/>
        public IList<IOrganiser> ReadAllOrganisers()
        {
            return this.Context.Organisers
                .AsNoTracking()
                .ToList()
                .Select(erg => erg.ToDomain())
                .ToList();
        }

        /// <inheritdoc/>
        public IList<IOwner> ReadAllOwners()
        {
            return this.Context.Owners
                .AsNoTracking()
                .ToList()
                .Select(o => o.ToDomain())
                .ToList();
        }

        /// <inheritdoc/>
        public IList<IPackColour> ReadAllPackColours()
        {
            return this.Context.PackColours
                .AsNoTracking()
                .ToList()
                .Select(pc => pc.ToDomain())
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

        /// <inheritdoc/>
        public IList<ISeason> ReadAllSeasons()
        {
            return this.Context.Seasons
                .AsNoTracking()
                .ToList()
                .Select(s => s.ToDomain())
                .ToList();
        }

        /// <inheritdoc/>
        public IList<ISet> ReadAllSets()
        {
            return this.Context.Sets
                .AsNoTracking()
                .Include(s => s.Owner)
                .Include(s => s.SetPurpose)
                .Include(s => s.SetColour)
                .ToList()
                .Select(s => s.ToDomain())
                .ToList();
        }

        /// <inheritdoc/>
        public IList<ISetPurpose> ReadAllSetPurposes()
        {
            return this.Context.SetPurposes
                .AsNoTracking()
                .ToList()
                .Select(sp => sp.ToDomain())
                .ToList();
        }

        /// <inheritdoc/>
        public IList<ISetColour> ReadAllSetColours()
        {
            return this.Context.SetColours
                .AsNoTracking()
                .ToList()
                .Select(sc => sc.ToDomain())
                .ToList();
        }

        /// <inheritdoc/>
        public IList<ISuit> ReadAllSuits()
        {
            return this.Context.Suits
                .AsNoTracking()
                .ToList()
                .Select(s => s.ToDomain())
                .ToList();
        }
    }
}