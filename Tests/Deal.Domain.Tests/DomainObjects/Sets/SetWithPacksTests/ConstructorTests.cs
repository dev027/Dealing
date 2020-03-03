// <copyright file="ConstructorTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using Deal.Domain.DomainObjects.Owners;
using Deal.Domain.DomainObjects.PackColours;
using Deal.Domain.DomainObjects.Packs;
using Deal.Domain.DomainObjects.SetColours;
using Deal.Domain.DomainObjects.SetPurposes;
using Deal.Domain.DomainObjects.Sets;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Domain.Tests.DomainObjects.Sets.SetWithPacksTests
{
    /// <summary>
    /// Test the constructor for <see cref="SetWithPacks"/>.
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
            ISet paramSet = new Set(
                id: Guid.NewGuid(),
                lowBoardNumber: 1,
                highBoardNumber: 2,
                description: "Test Set",
                owner: new Owner(
                    id: Guid.NewGuid(),
                    code: "CBC",
                    name: "County Bridge Club",
                    isClub: true),
                setPurpose: new SetPurpose(
                    id: Guid.NewGuid(),
                    code: "DEMO",
                    name: "Demo"),
                setColour: new SetColour(
                    id: Guid.NewGuid(),
                    code: "YELLOW",
                    name: "Yellow"));
            IList<IPack> paramPacks = new List<IPack>
            {
                new Pack(
                    id: Guid.NewGuid(),
                    packColour: new PackColour(
                        id: Guid.NewGuid(),
                        code: "RED",
                        colour: "Red"),
                    set: paramSet,
                    enteredService: DateTime.Today,
                    boardNumber: 1),
                new Pack(
                    id: Guid.NewGuid(),
                    packColour: new PackColour(
                        id: Guid.NewGuid(),
                        code: "BLUE",
                        colour: "Blue"),
                    set: paramSet,
                    enteredService: DateTime.Today,
                    boardNumber: 2)
            };

            // ACT
            ISetWithPacks setWithPacks = new SetWithPacks(
                set: paramSet,
                packs: paramPacks);

            // ASSERT
            Assert.AreEqual(paramSet.Id, setWithPacks.Id);
            Assert.AreEqual(paramSet.LowBoardNumber, setWithPacks.LowBoardNumber);
            Assert.AreEqual(paramSet.HighBoardNumber, setWithPacks.HighBoardNumber);
            Assert.AreEqual(paramSet.Description, setWithPacks.Description);
            Assert.AreSame(paramSet.Owner, setWithPacks.Owner);
            Assert.AreSame(paramSet.SetPurpose, setWithPacks.SetPurpose);
            Assert.AreSame(paramSet.SetColour, setWithPacks.SetColour);
            Assert.IsNotNull(setWithPacks.Packs);
            Assert.AreEqual(paramPacks.Count, setWithPacks.Packs.Count);
        }

        /// <summary>
        /// Tests the constructor with null set throws exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Constructor_Null_Set_Throws_Exception()
        {
            // ARRANGE
            ISet paramSet = new Set(
                id: Guid.NewGuid(),
                lowBoardNumber: 1,
                highBoardNumber: 2,
                description: "Test Set",
                owner: new Owner(
                    id: Guid.NewGuid(),
                    code: "CBC",
                    name: "County Bridge Club",
                    isClub: true),
                setPurpose: new SetPurpose(
                    id: Guid.NewGuid(),
                    code: "DEMO",
                    name: "Demo"),
                setColour: new SetColour(
                    id: Guid.NewGuid(),
                    code: "YELLOW",
                    name: "Yellow"));
            IList<IPack> paramPacks = new List<IPack>
            {
                new Pack(
                    id: Guid.NewGuid(),
                    packColour: new PackColour(
                        id: Guid.NewGuid(),
                        code: "RED",
                        colour: "Red"),
                    set: paramSet,
                    enteredService: DateTime.Today,
                    boardNumber: 1),
                new Pack(
                    id: Guid.NewGuid(),
                    packColour: new PackColour(
                        id: Guid.NewGuid(),
                        code: "BLUE",
                        colour: "Blue"),
                    set: paramSet,
                    enteredService: DateTime.Today,
                    boardNumber: 2)
            };

            // ACT
            _ = new SetWithPacks(
                set: null,
                packs: paramPacks);

            // ASSERT
            Assert.Fail();
        }

        /// <summary>
        /// Tests the constructor with null packs throws exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Constructor_Null_Packs_Throws_Exception()
        {
            // ARRANGE
            ISet paramSet = new Set(
                id: Guid.NewGuid(),
                lowBoardNumber: 1,
                highBoardNumber: 2,
                description: "Test Set",
                owner: new Owner(
                    id: Guid.NewGuid(),
                    code: "CBC",
                    name: "County Bridge Club",
                    isClub: true),
                setPurpose: new SetPurpose(
                    id: Guid.NewGuid(),
                    code: "DEMO",
                    name: "Demo"),
                setColour: new SetColour(
                    id: Guid.NewGuid(),
                    code: "YELLOW",
                    name: "Yellow"));

            // ACT
            _ = new SetWithPacks(
                set: paramSet,
                packs: null);

            // ASSERT
            Assert.Fail();
        }
    }
}