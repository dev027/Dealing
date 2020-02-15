// <copyright file="SeedService.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using Deal.Data.Crud;
using Deal.Domain.DomainObjects.Ranks;
using Deal.Domain.DomainObjects.Suits;
using DoItWright.Library.DependencyInjection;

namespace Deal.Service.SeedServices
{
    /// <summary>
    /// Seed Service.
    /// </summary>
    /// <seealso cref="ISeedService" />
    public class SeedService : ISeedService
    {
        /// <summary>
        /// Seed the Ranks.
        /// </summary>
        public void Ranks()
        {
            using IDealData data = InstanceFactory.GetInstance<IDealData>();

            if (data.AnyRank())
            {
                return;
            }

            IDictionary<string, string> rankDetails = new Dictionary<string, string>
            {
                { "A", "Ace" },
                { "K", "King" },
                { "Q", "Queen" },
                { "J", "Jack" },
                { "10", "Ten" },
                { "9", "Nine" },
                { "8", "Eight" },
                { "7", "Seven" },
                { "6", "Six" },
                { "5", "Five" },
                { "4", "Four" },
                { "3", "Three" },
                { "2", "Two" }
            };

            short sortOrder = 1;
            foreach (KeyValuePair<string, string> rankDetail in rankDetails)
            {
                IRank rank = new Rank(
                    id: Guid.NewGuid(),
                    code: rankDetail.Key,
                    name: rankDetail.Value,
                    sortOrder: sortOrder++);
                data.CreateRank(rank);
            }
        }

        /// <summary>
        /// Seeds the Suits.
        /// </summary>
        public void Suits()
        {
            using IDealData data = InstanceFactory.GetInstance<IDealData>();

            if (data.AnySuit())
            {
                return;
            }

            IList<string> suitNames = new List<string>
            {
                "Spades", "Hearts", "Diamonds", "Clubs"
            };

            short sortOrder = 1;
            foreach (string suitName in suitNames)
            {
                ISuit suit = new Suit(
                    id: Guid.NewGuid(),
                    code: suitName.Substring(0, 1),
                    name: suitName,
                    sortOrder: sortOrder++);
                data.CreateSuit(suit);
            }
        }
    }
}