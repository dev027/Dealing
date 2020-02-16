// <copyright file="ConstructorTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Domain.DomainObjects.Cards;
using Deal.Domain.DomainObjects.Ranks;
using Deal.Domain.DomainObjects.Suits;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Domain.Tests.DomainObjects.Cards.CardTests
{
    /// <summary>
    /// Test the constructor for <see cref="Card"/>.
    /// </summary>
    [TestClass]
    public class ConstructorTests
    {
        /// <summary>
        /// Tests the basic constructor.
        /// </summary>
        [TestMethod]
        public void Test_Basic_Constructor()
        {
            // ARRANGE
            Guid paramGuid = Guid.NewGuid();

            ISuit paramSuit = new Suit(
                id: Guid.NewGuid(),
                code: "S",
                name: "Spades",
                sortOrder: 1);

            IRank paramRank = new Rank(
                id: Guid.NewGuid(),
                code: "A",
                name: "Ace",
                sortOrder: 1);

            // ACT
            ICard card = new Card(
                id: paramGuid,
                suit: paramSuit,
                rank: paramRank);

            // ASSERT
            Assert.AreEqual(paramGuid, card.Id);
            Assert.AreSame(paramSuit, card.Suit);
            Assert.AreSame(paramRank, card.Rank);
        }

        /// <summary>
        /// Tests the constructor null code throws exception.
        /// </summary>
        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void Test_Constructor_Null_Suit_Throws_Exception()
        {
            // ARRANGE
            Guid paramGuid = Guid.NewGuid();

            IRank paramRank = new Rank(
                id: Guid.NewGuid(),
                code: "A",
                name: "Ace",
                sortOrder: 1);

            // ACT
            _ = new Card(
                id: paramGuid,
                suit: null,
                rank: paramRank);

            // ASSERT
            Assert.Fail();
        }

        /// <summary>
        /// Tests the constructor null rank throws exception.
        /// </summary>
        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void Test_Constructor_Null_Rank_Throws_Exception()
        {
            // ARRANGE
            Guid paramGuid = Guid.NewGuid();

            ISuit paramSuit = new Suit(
                id: Guid.NewGuid(),
                code: "S",
                name: "Spades",
                sortOrder: 1);

            // ACT
            _ = new Card(
                id: paramGuid,
                suit: paramSuit,
                rank: null);

            // ASSERT
            Assert.Fail();
        }
    }
}