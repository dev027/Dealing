﻿// <copyright file="SeedService.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using Deal.Data.Crud;
using Deal.Domain.DomainObjects.Cards;
using Deal.Domain.DomainObjects.ErrorReasonGroups;
using Deal.Domain.DomainObjects.PackColours;
using Deal.Domain.DomainObjects.Ranks;
using Deal.Domain.DomainObjects.SetColours;
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

        /// <inheritdoc />
        public void ErrorReasonGroups()
        {
            using IDealData data = InstanceFactory.GetInstance<IDealData>();

            if (data.AnyErrorReasonGroup())
            {
                return;
            }

            IDictionary<string, string> errorReasonGroupDetails = new Dictionary<string, string>
            {
                { "SET", "Set" },
                { "PACK", "Pack" }
            };

            foreach (KeyValuePair<string, string> errorReasonGroupDetail in errorReasonGroupDetails)
            {
                IErrorReasonGroup errorReasonGroup = new ErrorReasonGroup(
                    id: Guid.NewGuid(),
                    code: errorReasonGroupDetail.Key,
                    name: errorReasonGroupDetail.Value);
                data.CreateErrorReasonGroup(errorReasonGroup);
            }
        }

        /// <inheritdoc/>
        public void PackColours()
        {
            using IDealData data = InstanceFactory.GetInstance<IDealData>();

            if (data.AnyPackColour())
            {
                return;
            }

            IList<string> colours = new List<string>
            {
                "Red", "Blue"
            };

            foreach (string colour in colours)
            {
                IPackColour packColour = new PackColour(
                    id: Guid.NewGuid(),
                    code: colour.Substring(0, 1),
                    colour: colour);
                data.CreatePackColour(packColour);
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
        public void SetColours()
        {
            using IDealData data = InstanceFactory.GetInstance<IDealData>();

            if (data.AnySetColours())
            {
                return;
            }

            IDictionary<string, string> setColourDetails = new Dictionary<string, string>
            {
                { "DK-BLUE", "Dark Blue" },
                { "DK-GREEN", "Dark Green" },
                { "LT-BLUE", "Light Blue" },
                { "LT-GREEN", "Light Green" },
                { "WHITE", "Off White" },
                { "ORANGE", "Orange" },
                { "PINK", "Pink" },
                { "RED", "Red" },
                { "YELLOW", "Yellow" }
            };

            foreach (KeyValuePair<string, string> setColourDetail in setColourDetails)
            {
                ISetColour setColour = new SetColour(
                    id: Guid.NewGuid(),
                    code: setColourDetail.Key,
                    name: setColourDetail.Value);
                data.CreateSetColour(setColour);
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