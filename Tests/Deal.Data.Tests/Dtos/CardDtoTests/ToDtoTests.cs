// <copyright file="ToDtoTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Data.Dtos;
using Deal.Domain.DomainObjects.Cards;
using Deal.Domain.DomainObjects.Ranks;
using Deal.Domain.DomainObjects.Suits;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Data.Tests.Dtos.CardDtoTests
{
    /// <summary>
    /// Test <see cref="CardDto.ToDto"/>.
    /// </summary>
    [TestClass]
    public class ToDtoTests
    {
        /// <summary>
        /// Tests method with valid values.
        /// </summary>
        [TestMethod]
        public void Test_Passing_Valid_Values()
        {
            // ARRANGE
            ICard card = new Card(
                id: Guid.NewGuid(),
                suit: new Suit(
                    id: Guid.NewGuid(),
                    code: "S",
                    name: "Spades",
                    sortOrder: 1),
                rank: new Rank(
                    id: Guid.NewGuid(),
                    code: "A",
                    name: "Ace",
                    sortOrder: 1));

            // ACT
            CardDto cardDto = CardDto.ToDto(card);

            // ASSERT
            Assert.AreEqual(card.Id, cardDto.Id);
            Assert.AreEqual(card.Suit.Id, cardDto.SuitId);
            Assert.AreEqual(card.Rank.Id, cardDto.RankId);
        }

        /// <summary>
        /// Tests passing null card throws exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Passing_Null_Card_Throws_Exception()
        {
            // ACT
            _ = CardDto.ToDto(null);
        }
    }
}