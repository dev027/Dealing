using System;
using System.Collections.Generic;
using Deal.Data.Crud;
using Deal.Domain.DomainObjects.Ranks;
using Deal.Domain.DomainObjects.Suits;

namespace Deal.Migration
{
    public static class Program
    {
        /// <summary>
        /// Main
        /// </summary>
        public static void Main(/*string[] args*/)
        {
            using IDealData data = new DealData();
            SeedSuits(data);
            SeedRanks(data);

        }

        private static void SeedRanks(IDealData data)
        {
            if (data.AnyRank())
            {
                return;
            }

            IDictionary<string, string> rankDetails = new Dictionary<string, string>
            {
                {"A", "Ace"},
                {"K", "King"},
                {"Q", "Queen"},
                {"J", "Jack"},
                {"10", "Ten"},
                {"9", "Nine"},
                {"8", "Eight"},
                {"7", "Seven"},
                {"6", "Six"},
                {"5", "Five"},
                {"4", "Four"},
                {"3", "Three"},
                {"2", "Two"}
            };

            short sortOrder = 1;
            foreach (KeyValuePair<string, string> rankDetail in rankDetails)
            {
                Rank rank = new Rank(
                    id: Guid.NewGuid(),
                    code: rankDetail.Key,
                    name: rankDetail.Value,
                    sortOrder: sortOrder++);
                data.CreateRank(rank);
            }
        }

        /// <summary>
        /// SeedSuits
        /// </summary>
        /// <param name="data"></param>
        /// <exception cref="Microsoft.EntityFrameworkCore.DbUpdateException"></exception>
        /// <exception cref="Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException"></exception>
        /// <exception cref="ApplicationException"></exception>
        private static void SeedSuits(IDealData data)
        {
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
                Suit suit = new Suit(
                    id: Guid.NewGuid(),
                    code: suitName.Substring(0, 1),
                    name: suitName,
                    sortOrder: sortOrder++);
                data.CreateSuit(suit);
            }
        }
    }
}
