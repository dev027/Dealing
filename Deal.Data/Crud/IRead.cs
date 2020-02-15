// <copyright file="IRead.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System.Collections.Generic;
using Deal.Domain.DomainObjects.Ranks;
using Deal.Domain.DomainObjects.Suits;

namespace Deal.Data.Crud
{
    /// <summary>
    /// Read methods.
    /// </summary>
    public interface IRead
    {
        /// <summary>
        /// Reads all Suits.
        /// </summary>
        /// <returns>List of Suits.</returns>
        IList<ISuit> ReadAllSuits();

        /// <summary>
        /// Reads all Ranks.
        /// </summary>
        /// <returns>List of Ranks.</returns>
        IList<IRank> ReadAllRanks();
    }
}