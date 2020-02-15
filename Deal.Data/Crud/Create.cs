﻿// <copyright file="Create.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Data.Dtos;
using Deal.Domain.DomainObjects.Cards;
using Deal.Domain.DomainObjects.Ranks;
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
    }
}