// <copyright file="IRead.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System.Collections.Generic;
using Deal.Domain.DomainObjects.Dealers;
using Deal.Domain.DomainObjects.ErrorReasonGroups;
using Deal.Domain.DomainObjects.Organisers;
using Deal.Domain.DomainObjects.Owners;
using Deal.Domain.DomainObjects.Ranks;
using Deal.Domain.DomainObjects.SetColours;
using Deal.Domain.DomainObjects.SetPurposes;
using Deal.Domain.DomainObjects.Sets;
using Deal.Domain.DomainObjects.Suits;

namespace Deal.Data.Crud
{
    /// <summary>
    /// Read methods.
    /// </summary>
    public interface IRead
    {
        /// <summary>
        /// Reads all Dealers.
        /// </summary>
        /// <returns>List of Dealers.</returns>
        IList<IDealer> ReadAllDealers();

        /// <summary>
        /// Reads all Error Reason Groups.
        /// </summary>
        /// <returns>List of Error Reason Groups.</returns>
        IList<IErrorReasonGroup> ReadAllErrorReasonGroups();

        /// <summary>
        /// Reads all Organisers.
        /// </summary>
        /// <returns>List of Organisers.</returns>
        IList<IOrganiser> ReadAllOrganisers();

        /// <summary>
        /// Reads all Owners.
        /// </summary>
        /// <returns>List of Owners.</returns>
        IList<IOwner> ReadAllOwners();

        /// <summary>
        /// Reads all Ranks.
        /// </summary>
        /// <returns>List of Ranks.</returns>
        IList<IRank> ReadAllRanks();

        /// <summary>
        /// Reads all Sets.
        /// </summary>
        /// <returns>List of Sets.</returns>
        IList<ISet> ReadAllSets();

        /// <summary>
        /// Reads all Set Purposes.
        /// </summary>
        /// <returns>List of Set Purposes.</returns>
        IList<ISetPurpose> ReadAllSetPurposes();

        /// <summary>
        /// Reads all Set Colours.
        /// </summary>
        /// <returns>List of Set Colours.</returns>
        IList<ISetColour> ReadAllSetColours();

        /// <summary>
        /// Reads all Suits.
        /// </summary>
        /// <returns>List of Suits.</returns>
        IList<ISuit> ReadAllSuits();
    }
}