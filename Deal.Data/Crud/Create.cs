﻿// <copyright file="Create.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Data.Dtos;
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

namespace Deal.Data.Crud
{
    /// <summary>
    /// Data access layer - Create methods.
    /// </summary>
    /// <seealso cref="IDealData" />
    public partial class DealData
    {
        /// <inheritdoc/>
        public void CreateCard(ICard card)
        {
            CardDto cardDto = CardDto.ToDto(card);
            this.Context.Cards.Add(cardDto);
            int count = this.Context.SaveChanges();

            if (count != 1)
            {
                throw new ApplicationException($"Unexpectedly created {count} rows");
            }
        }

        /// <inheritdoc/>
        public void CreateDealer(IDealer dealer)
        {
            DealerDto dealerDto = DealerDto.ToDto(dealer);
            this.Context.Dealers.Add(dealerDto);
            int count = this.Context.SaveChanges();

            if (count != 1)
            {
                throw new ApplicationException($"Unexpectedly created {count} rows");
            }
        }

        /// <inheritdoc/>
        public void CreateErrorReason(IErrorReason errorReason)
        {
            ErrorReasonDto errorReasonDto = ErrorReasonDto.ToDto(errorReason);
            this.Context.ErrorReasons.Add(errorReasonDto);
            int count = this.Context.SaveChanges();

            if (count != 1)
            {
                throw new ApplicationException($"Unexpectedly created {count} rows");
            }
        }

        /// <inheritdoc/>
        public void CreateErrorReasonGroup(IErrorReasonGroup errorReasonGroup)
        {
            ErrorReasonGroupDto errorReasonGroupDto = ErrorReasonGroupDto.ToDto(errorReasonGroup);
            this.Context.ErrorReasonGroups.Add(errorReasonGroupDto);
            int count = this.Context.SaveChanges();

            if (count != 1)
            {
                throw new ApplicationException($"Unexpectedly created {count} rows");
            }
        }

        /// <inheritdoc/>
        public void CreateOrganiser(IOrganiser organiser)
        {
            OrganiserDto organiserDto = OrganiserDto.ToDto(organiser);
            this.Context.Organisers.Add(organiserDto);
            int count = this.Context.SaveChanges();

            if (count != 1)
            {
                throw new ApplicationException($"Unexpectedly created {count} rows");
            }
        }

        /// <inheritdoc />
        public void CreateOwner(IOwner owner)
        {
            OwnerDto ownerDto = OwnerDto.ToDto(owner);
            this.Context.Owners.Add(ownerDto);
            int count = this.Context.SaveChanges();

            if (count != 1)
            {
                throw new ApplicationException($"Unexpectedly created {count} rows");
            }
        }

        /// <inheritdoc />
        public void CreatePack(IPack pack)
        {
            PackDto packDto = PackDto.ToDto(pack);
            this.Context.Packs.Add(packDto);
            int count = this.Context.SaveChanges();

            if (count != 1)
            {
                throw new ApplicationException($"Unexpectedly created {count} rows");
            }
        }

        /// <inheritdoc/>
        public void CreatePackColour(IPackColour packColour)
        {
            PackColourDto packColourDto = PackColourDto.ToDto(packColour);
            this.Context.PackColours.Add(packColourDto);
            int count = this.Context.SaveChanges();

            if (count != 1)
            {
                throw new ApplicationException($"Unexpectedly created {count} rows");
            }
        }

        /// <inheritdoc/>
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

        /// <inheritdoc />
        public void CreateSeason(ISeason season)
        {
            SeasonDto seasonDto = SeasonDto.ToDto(season);
            this.Context.Seasons.Add(seasonDto);
            int count = this.Context.SaveChanges();

            if (count != 1)
            {
                throw new ApplicationException($"Unexpectedly created {count} rows");
            }
        }

        /// <inheritdoc/>
        public void CreateSet(ISet set)
        {
            SetDto setDto = SetDto.ToDto(set);
            this.Context.Sets.Add(setDto);
            int count = this.Context.SaveChanges();

            if (count != 1)
            {
                throw new ApplicationException($"Unexpectedly created {count} rows");
            }
        }

        /// <inheritdoc/>
        public void CreateSetColour(ISetColour setColour)
        {
            SetColourDto setColourDto = SetColourDto.ToDto(setColour);
            this.Context.SetColours.Add(setColourDto);
            int count = this.Context.SaveChanges();

            if (count != 1)
            {
                throw new ApplicationException($"Unexpectedly created {count} rows");
            }
        }

        /// <inheritdoc/>
        public void CreateSetPurpose(ISetPurpose setPurpose)
        {
            SetPurposeDto setPurposeDto = SetPurposeDto.ToDto(setPurpose);
            this.Context.SetPurposes.Add(setPurposeDto);
            int count = this.Context.SaveChanges();

            if (count != 1)
            {
                throw new ApplicationException($"Unexpectedly created {count} rows");
            }
        }

        /// <inheritdoc/>
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
    }
}