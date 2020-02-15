// <copyright file="SeedService.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using Deal.Data.Crud;
using Deal.Domain.DomainObjects.Cards;
using Deal.Domain.DomainObjects.Ranks;
using Deal.Domain.DomainObjects.Suits;
using Deal.Service.Resources;
using DoItWright.Library.DependencyInjection;

namespace Deal.Service.SeedServices
{
    /// <summary>
    /// Seed Service.
    /// </summary>
    /// <seealso cref="ISeedService" />
    public class SeedService : ISeedService
    {
        /// <inheritdoc/>
        public void Cards()
        {
            using IDealData data = InstanceFactory.GetInstance<IDealData>();

            if (data.AnyCard())
            {
                return;
            }

            IList<ISuit> suits = data.ReadAllSuits();

            if (suits.Count == 0)
            {
                throw new InvalidOperationException(ExceptionResource.MustSeedSuitsBeforeSeedingCards);
            }

            IList<IRank> ranks = data.ReadAllRanks();

            if (suits.Count == 0)
            {
                throw new InvalidOperationException(ExceptionResource.MustSeedSuitsBeforeSeedingCards);
            }

            foreach (ISuit suit in suits)
            {
                foreach (IRank rank in ranks)
                {
                    data.CreateCard(new Card(
                        id: Guid.NewGuid(),
                        suit: suit,
                        rank: rank));
                }
            }
        }

        /// <inheritdoc/>
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

        /// <inheritdoc/>
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