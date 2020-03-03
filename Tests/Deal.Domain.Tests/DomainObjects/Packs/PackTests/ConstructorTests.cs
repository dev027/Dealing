// <copyright file="ConstructorTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Domain.DomainObjects.Owners;
using Deal.Domain.DomainObjects.PackColours;
using Deal.Domain.DomainObjects.Packs;
using Deal.Domain.DomainObjects.SetColours;
using Deal.Domain.DomainObjects.SetPurposes;
using Deal.Domain.DomainObjects.Sets;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Domain.Tests.DomainObjects.Packs.PackTests
{
    /// <summary>
    /// Test the constructor for <see cref="Pack"/>.
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
            IPackColour paramPackColour = new PackColour(
                id: Guid.NewGuid(),
                code: "BLUE",
                colour: "Blue");
            ISet paramSet = new Set(
                id: Guid.NewGuid(),
                lowBoardNumber: 1,
                highBoardNumber: 32,
                description: "Test",
                owner: new Owner(
                    id: Guid.NewGuid(),
                    code: "CBC",
                    name: "County Bridge Club",
                    isClub: true),
                setPurpose: new SetPurpose(
                    id: Guid.NewGuid(),
                    code: "TEACH",
                    name: "Teaching"),
                setColour: new SetColour(
                    id: Guid.NewGuid(),
                    code: "YELLOW",
                    name: "Yellow"));
            DateTime paramEnteredService = new DateTime(2019, 12, 31);
            const int paramBoardNumber = 15;

            // ACT
            IPack pack = new Pack(
                paramGuid,
                paramPackColour,
                paramSet,
                paramEnteredService,
                paramBoardNumber);

            // ASSERT
            Assert.AreEqual(paramGuid, pack.Id);
            Assert.AreSame(paramPackColour, pack.PackColour);
            Assert.AreSame(paramSet, pack.Set);
            Assert.AreEqual(paramEnteredService, pack.EnteredService);
            Assert.AreEqual(paramBoardNumber, pack.BoardNumber);
        }

        /// <summary>
        /// Tests the constructor null pack colour throws exception.
        /// </summary>
        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void Test_Constructor_Null_Pack_Colour_Throws_Exception()
        {
            // ARRANGE
            Guid paramGuid = Guid.NewGuid();
            ISet paramSet = new Set(
                id: Guid.NewGuid(),
                lowBoardNumber: 1,
                highBoardNumber: 32,
                description: "Test",
                owner: new Owner(
                    id: Guid.NewGuid(),
                    code: "CBC",
                    name: "County Bridge Club",
                    isClub: true),
                setPurpose: new SetPurpose(
                    id: Guid.NewGuid(),
                    code: "TEACH",
                    name: "Teaching"),
                setColour: new SetColour(
                    id: Guid.NewGuid(),
                    code: "YELLOW",
                    name: "Yellow"));
            DateTime paramEnteredService = new DateTime(2019, 12, 31);
            const int paramBoardNumber = 15;

            // ACT
            _ = new Pack(
                paramGuid,
                null,
                paramSet,
                paramEnteredService,
                paramBoardNumber);

            // ASSERT
            Assert.Fail();
        }

        /// <summary>
        /// Tests the constructor null set throws exception.
        /// </summary>
        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void Test_Constructor_Null_Set_Throws_Exception()
        {
            // ARRANGE
            Guid paramGuid = Guid.NewGuid();
            IPackColour paramPackColour = new PackColour(
                id: Guid.NewGuid(),
                code: "BLUE",
                colour: "Blue");
            DateTime paramEnteredService = new DateTime(2019, 12, 31);
            const int paramBoardNumber = 15;

            // ACT
            _ = new Pack(
                paramGuid,
                paramPackColour,
                null,
                paramEnteredService,
                paramBoardNumber);

            // ASSERT
            Assert.Fail();
        }

        /// <summary>
        /// Tests the constructor low board number throws exception.
        /// </summary>
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void Test_Constructor_Low_Board_Number_Throws_Exception()
        {
            // ARRANGE
            Guid paramGuid = Guid.NewGuid();
            IPackColour paramPackColour = new PackColour(
                id: Guid.NewGuid(),
                code: "BLUE",
                colour: "Blue");
            ISet paramSet = new Set(
                id: Guid.NewGuid(),
                lowBoardNumber: 1,
                highBoardNumber: 32,
                description: "Test",
                owner: new Owner(
                    id: Guid.NewGuid(),
                    code: "CBC",
                    name: "County Bridge Club",
                    isClub: true),
                setPurpose: new SetPurpose(
                    id: Guid.NewGuid(),
                    code: "TEACH",
                    name: "Teaching"),
                setColour: new SetColour(
                    id: Guid.NewGuid(),
                    code: "YELLOW",
                    name: "Yellow"));
            DateTime paramEnteredService = new DateTime(2019, 12, 31);
            const int paramBoardNumber = 0;

            // ACT
            _ = new Pack(
                paramGuid,
                paramPackColour,
                paramSet,
                paramEnteredService,
                paramBoardNumber);

            // ASSERT
            Assert.Fail();
        }

        /// <summary>
        /// Tests the constructor high board number throws exception.
        /// </summary>
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void Test_Constructor_High_Board_Number_Throws_Exception()
        {
            // ARRANGE
            Guid paramGuid = Guid.NewGuid();
            IPackColour paramPackColour = new PackColour(
                id: Guid.NewGuid(),
                code: "BLUE",
                colour: "Blue");
            ISet paramSet = new Set(
                id: Guid.NewGuid(),
                lowBoardNumber: 1,
                highBoardNumber: 32,
                description: "Test",
                owner: new Owner(
                    id: Guid.NewGuid(),
                    code: "CBC",
                    name: "County Bridge Club",
                    isClub: true),
                setPurpose: new SetPurpose(
                    id: Guid.NewGuid(),
                    code: "TEACH",
                    name: "Teaching"),
                setColour: new SetColour(
                    id: Guid.NewGuid(),
                    code: "YELLOW",
                    name: "Yellow"));
            DateTime paramEnteredService = new DateTime(2019, 12, 31);
            const int paramBoardNumber = 100;

            // ACT
            _ = new Pack(
                paramGuid,
                paramPackColour,
                paramSet,
                paramEnteredService,
                paramBoardNumber);

            // ASSERT
            Assert.Fail();
        }
    }
}