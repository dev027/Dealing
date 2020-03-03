// <copyright file="SeedService.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using Deal.Data.Crud;
using Deal.Domain.DomainFactories.Sets;
using Deal.Domain.DomainObjects.Cards;
using Deal.Domain.DomainObjects.Dealers;
using Deal.Domain.DomainObjects.ErrorReasonGroups;
using Deal.Domain.DomainObjects.ErrorReasons;
using Deal.Domain.DomainObjects.Organisers;
using Deal.Domain.DomainObjects.Owners;
using Deal.Domain.DomainObjects.PackColours;
using Deal.Domain.DomainObjects.Packs;
using Deal.Domain.DomainObjects.Ranks;
using Deal.Domain.DomainObjects.Seasons;
using Deal.Domain.DomainObjects.SetColours;
using Deal.Domain.DomainObjects.SetPurposes;
using Deal.Domain.DomainObjects.Sets;
using Deal.Domain.DomainObjects.Suits;
using Deal.Service.Resources;
using DoItWright.Library.DependencyInjection;
using DoItWright.Library.Logging;

namespace Deal.Service.SeedServices
{
    /// <summary>
    /// Seed Service.
    /// </summary>
    /// <seealso cref="ISeedService" />
    public class SeedService : ISeedService
    {
        /// <inheritdoc/>
        public void Cards(ICaller caller)
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
        public void Dealers(ICaller caller)
        {
            using IDealData data = InstanceFactory.GetInstance<IDealData>();

            IList<IDealer> existingDealers = data.ReadAllDealers();

            IList<string> dealerNames = new List<string>
            {
                "Steve",
                "Anne"
            };

            foreach (string dealerName in dealerNames)
            {
                if (existingDealers.Any(d => d.Name == dealerName))
                {
                    continue;
                }

                IDealer dealer = new Dealer(
                    id: Guid.NewGuid(),
                    name: dealerName);

                data.CreateDealer(dealer);
                Console.WriteLine($@"Seeding Dealer: {dealerName}.");
            }
        }

        /// <inheritdoc />
        public void ErrorReasonGroups(ICaller caller)
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
        public void Organisers(ICaller caller)
        {
            using IDealData data = InstanceFactory.GetInstance<IDealData>();

            IList<IOrganiser> existingOrganisers = data.ReadAllOrganisers();

            IDictionary<string, string> organiserDetails = new Dictionary<string, string>
            {
                { "LCBA", "LCBA" },
                { "CBC", "County Bridge Club" },
                { "BRADGATE", "Bradgate Bridge Club" },
                { "GLENFIELD", "Glenfield Bridge Club" },
                { "CBT", "Charnwood Bridge Teachers" }
            };

            foreach (KeyValuePair<string, string> organiserDetail in organiserDetails)
            {
                if (existingOrganisers.Any(o => o.Code == organiserDetail.Key))
                {
                    continue;
                }

                IOrganiser organiser = new Organiser(
                    id: Guid.NewGuid(),
                    code: organiserDetail.Key,
                    name: organiserDetail.Value);

                data.CreateOrganiser(organiser);
                Console.WriteLine($@"Seeding Dealer: {organiser.Name}.");
            }
        }

        /// <inheritdoc/>
        public void Owners(ICaller caller)
        {
            using IDealData data = InstanceFactory.GetInstance<IDealData>();

            if (data.AnyOwner())
            {
                return;
            }

            IDictionary<string, string> ownerDetails = new Dictionary<string, string>
            {
                { "LCBA", "LCBA" },
                { "CBC", "County Bridge Club" },
                { "BRADGATE", "Bradgate Bridge Club" },
                { "GLENFIELD", "Glenfield Bridge Club" },
                { "CBT", "Charnwood Bridge Teachers" }
            };

            foreach (KeyValuePair<string, string> ownerDetail in ownerDetails)
            {
                IOwner owner = new Owner(
                    id: Guid.NewGuid(),
                    code: ownerDetail.Key,
                    name: ownerDetail.Value,
                    isClub: true);
                data.CreateOwner(owner);
            }

            ownerDetails = new Dictionary<string, string>
            {
                { "WRIGHT", "Steve/Anne Wright" }
            };

            foreach (KeyValuePair<string, string> ownerDetail in ownerDetails)
            {
                IOwner owner = new Owner(
                    id: Guid.NewGuid(),
                    code: ownerDetail.Key,
                    name: ownerDetail.Value,
                    isClub: false);
                data.CreateOwner(owner);
            }
        }

        /// <inheritdoc/>
        public void ErrorReasons(ICaller caller)
        {
            using IDealData data = InstanceFactory.GetInstance<IDealData>();

            if (data.AnyErrorReason())
            {
                return;
            }

            IList<IErrorReasonGroup> errorReasonGroups = data.ReadAllErrorReasonGroups();

            IErrorReasonGroup errorReasonGroupSet = errorReasonGroups
                .Single(erg => erg.Code == "SET");
            IErrorReasonGroup errorReasonGroupPack = errorReasonGroups
                .Single(erg => erg.Code == "PACK");

            IDictionary<string, string> errorReasonDetails = new Dictionary<string, string>
            {
                { "MULTIJAM", "Multi-card jam" },
                { "INVERTED", "Inverted card" },
                { "MISCOUNT", "Wrong number of cards in a hand" },
                { "MISSING", "Missing card" },
            };

            foreach (KeyValuePair<string, string> errorReasonGroupDetail in errorReasonDetails)
            {
                IErrorReason errorReason = new ErrorReason(
                    id: Guid.NewGuid(),
                    code: errorReasonGroupDetail.Key,
                    name: errorReasonGroupDetail.Value,
                    errorReasonGroup: errorReasonGroupSet);
                data.CreateErrorReason(errorReason);
            }

            errorReasonDetails = new Dictionary<string, string>
            {
                { "NOTKNOWN", "Card not recognised" },
                { "ALREADY-DEALT", "Card already dealt" },
                { "JAM", "Card jammed" }
            };

            foreach (KeyValuePair<string, string> errorReasonGroupDetail in errorReasonDetails)
            {
                IErrorReason errorReason = new ErrorReason(
                    id: Guid.NewGuid(),
                    code: errorReasonGroupDetail.Key,
                    name: errorReasonGroupDetail.Value,
                    errorReasonGroup: errorReasonGroupPack);
                data.CreateErrorReason(errorReason);
            }
        }

        /// <inheritdoc/>
        public void PackColours(ICaller caller)
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
        public void Ranks(ICaller caller)
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

        /// <inheritdoc />
        public void Seasons(ICaller caller)
        {
            using IDealData data = InstanceFactory.GetInstance<IDealData>();

            IList<ISeason> existingSeasons = data.ReadAllSeasons();

            IList<IOrganiser> existingOrganisers = data.ReadAllOrganisers();

            IList<ISeason> seasons = new List<ISeason>
            {
                new Season(
                    id: Guid.NewGuid(),
                    organiser: existingOrganisers.Single(o => o.Code == "BRADGATE"),
                    description: "2019/20",
                    startDate: new DateTime(2019, 11, 01),
                    endDate: new DateTime(2020, 10, 31)),
                new Season(
                    id: Guid.NewGuid(),
                    organiser: existingOrganisers.Single(o => o.Code == "GLENFIELD"),
                    description: "2019/20",
                    startDate: new DateTime(2019, 05, 23),
                    endDate: new DateTime(2020, 05, 20)),
                new Season(
                    id: Guid.NewGuid(),
                    organiser: existingOrganisers.Single(o => o.Code == "CBC"),
                    description: "2019/20",
                    startDate: new DateTime(2019, 06, 01),
                    endDate: new DateTime(2020, 05, 31)),
                new Season(
                    id: Guid.NewGuid(),
                    organiser: existingOrganisers.Single(o => o.Code == "CBT"),
                    description: "2019/20",
                    startDate: new DateTime(2019, 06, 01),
                    endDate: new DateTime(2020, 05, 31)),
                new Season(
                    id: Guid.NewGuid(),
                    organiser: existingOrganisers.Single(o => o.Code == "LCBA"),
                    description: "2019/20",
                    startDate: new DateTime(2019, 06, 01),
                    endDate: new DateTime(2020, 05, 31))
            };

            foreach (ISeason season in seasons)
            {
                ISeason existingSeason = existingSeasons
                    .Where(es => es.Organiser.Code == season.Organiser.Code)
                    .SingleOrDefault(es => es.Description == season.Description);

                if (existingSeason == null)
                {
                    data.CreateSeason(season);
                    Console.WriteLine($@"Seeding Season: {season.Organiser.Code} {season.Description}.");
                }
                else
                {
                    if (existingSeason.StartDate == season.StartDate &&
                        existingSeason.EndDate == season.EndDate)
                    {
                        continue;
                    }

                    existingSeason.SetDates(season.StartDate, season.EndDate);
                    data.UpdateSeason(existingSeason);

                    Console.WriteLine($@"Updating Season: {season.Organiser.Code} {season.Description}.");
                }
            }
        }

        /// <inheritdoc />
        public void Sets(ICaller caller)
        {
            using IDealData data = InstanceFactory.GetInstance<IDealData>();

            IList<ISet> existingSets = data.ReadAllSets();

            ISetWithPacksFactory setFactory = new SetWithPacksFactory(
                owners: data.ReadAllOwners(),
                packColours: data.ReadAllPackColours(),
                setPurposes: data.ReadAllSetPurposes(),
                setColours: data.ReadAllSetColours());

            IList<ISetWithPacks> setsWithPacks = new List<ISetWithPacks>
            {
                setFactory.Create32BoardSet("BRADGATE", "EVENTS", "LT-BLUE", "Blue"),
                setFactory.Create32BoardSet("BRADGATE", "EVENTS", "PINK", "Pink"),
                setFactory.Create32BoardSet("BRADGATE", "EVENTS", "LT-GREEN", "Green"),
                setFactory.Create32BoardSet("BRADGATE", "EVENTS", "WHITE", "White"),
                setFactory.Create32BoardSet("GLENFIELD", "EVENTS", "DK-BLUE", "Black"),
                setFactory.Create32BoardSet("GLENFIELD", "EVENTS", "LT-BLUE", "Blue"),
                setFactory.Create32BoardSet("GLENFIELD", "EVENTS", "DK-GREEN", "Green"),
                setFactory.Create32BoardSet("GLENFIELD", "EVENTS", "LT-GREEN", "Lime"),
                setFactory.Create32BoardSet("LCBA", "EVENTS", "DK-BLUE", "Black"),
                setFactory.Create32BoardSet("LCBA", "EVENTS", "ORANGE", "Orange"),
                setFactory.Create32BoardSet("LCBA", "EVENTS", "RED", "Red"),
                setFactory.Create32BoardSet("LCBA", "EVENTS", "YELLOW", "Yellow"),
                setFactory.Create32BoardSet("WRIGHT", "EVENTS", "YELLOW", "Yellow"),
            };

            foreach (ISetWithPacks setWithPacks in setsWithPacks)
            {
                if (existingSets.Where(es => es.Owner.Code == setWithPacks.Owner.Code)
                    .Where(es => es.SetPurpose.Code == setWithPacks.SetPurpose.Code)
                    .Where(es => es.SetColour.Code == setWithPacks.SetColour.Code)
                    .Any(es => es.Description == setWithPacks.Description))
                {
                    continue;
                }

                data.CreateSet(setWithPacks);
                foreach (IPack pack in setWithPacks.Packs)
                {
                    data.CreatePack(pack);
                }

                Console.WriteLine($@"Seeding Set: {setWithPacks.Owner.Code} {setWithPacks.Description}.");
            }
        }

        /// <inheritdoc/>
        public void SetColours(ICaller caller)
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
                { "YELLOW", "Yellow" },
                { "RAINBOW", "Rainbow" }
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
        public void SetPurposes(ICaller caller)
        {
            using IDealData data = InstanceFactory.GetInstance<IDealData>();

            if (data.AnySetPurpose())
            {
                return;
            }

            IDictionary<string, string> setPurposeDetails = new Dictionary<string, string>
            {
                { "TEACHING", "Teaching" },
                { "EVENTS", "Events" }
            };

            foreach (KeyValuePair<string, string> setPurposeDetail in setPurposeDetails)
            {
                ISetPurpose setPurpose = new SetPurpose(
                    id: Guid.NewGuid(),
                    code: setPurposeDetail.Key,
                    name: setPurposeDetail.Value);
                data.CreateSetPurpose(setPurpose);
            }
        }

        /// <inheritdoc/>
        public void Suits(ICaller caller)
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