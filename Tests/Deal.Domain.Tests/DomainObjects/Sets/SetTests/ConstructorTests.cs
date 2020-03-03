// <copyright file="ConstructorTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Domain.DomainObjects.Owners;
using Deal.Domain.DomainObjects.SetColours;
using Deal.Domain.DomainObjects.SetPurposes;
using Deal.Domain.DomainObjects.Sets;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Domain.Tests.DomainObjects.Sets.SetTests
{
    /// <summary>
    /// Test the constructor for <see cref="Set"/>.
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
            const int paramLowBoardNumber = 1;
            const int paramHighBoardNumber = 32;
            const string paramDescription = "Blue";

            IOwner paramOwner = new Owner(
                id: Guid.NewGuid(),
                code: "BRADGATE",
                name: "Bradgate",
                isClub: true);

            ISetPurpose paramSetPurpose = new SetPurpose(
                id: Guid.NewGuid(),
                code: "EVENT",
                name: "Events");

            ISetColour paramSetColour = new SetColour(
                id: Guid.NewGuid(),
                code: "LT-BLUE",
                name: "Light Blue");

            // ACT
            ISet set = new Set(
                id: paramGuid,
                lowBoardNumber: paramLowBoardNumber,
                highBoardNumber: paramHighBoardNumber,
                description: paramDescription,
                owner: paramOwner,
                setPurpose: paramSetPurpose,
                setColour: paramSetColour);

            // ASSERT
            Assert.AreEqual(paramGuid, set.Id);
            Assert.AreEqual(paramLowBoardNumber, set.LowBoardNumber);
            Assert.AreEqual(paramHighBoardNumber, set.HighBoardNumber);
            Assert.AreEqual(paramDescription, set.Description);
            Assert.AreSame(paramOwner, set.Owner);
            Assert.AreSame(paramSetPurpose, set.SetPurpose);
            Assert.AreSame(paramSetColour, set.SetColour);
        }

        /// <summary>
        /// Tests the constructor zero low board number throws exception.
        /// </summary>
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void Test_Constructor_Zero_Low_Board_Number_Throws_Exception()
        {
            // ARRANGE
            Guid paramGuid = Guid.NewGuid();
            const int paramLowBoardNumber = 0;
            const int paramHighBoardNumber = 32;
            const string paramDescription = "Blue";

            IOwner paramOwner = new Owner(
                id: Guid.NewGuid(),
                code: "BRADGATE",
                name: "Bradgate",
                isClub: true);

            ISetPurpose paramSetPurpose = new SetPurpose(
                id: Guid.NewGuid(),
                code: "EVENT",
                name: "Events");

            ISetColour paramSetColour = new SetColour(
                id: Guid.NewGuid(),
                code: "LT-BLUE",
                name: "Light Blue");

            // ACT
            _ = new Set(
                id: paramGuid,
                lowBoardNumber: paramLowBoardNumber,
                highBoardNumber: paramHighBoardNumber,
                description: paramDescription,
                owner: paramOwner,
                setPurpose: paramSetPurpose,
                setColour: paramSetColour);

            // ASSERT
            Assert.Fail();
        }

        /// <summary>
        /// Tests the constructor zero low board number greater than high board number throws exception.
        /// </summary>
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void Test_Constructor_Zero_Low_Board_Number_Greater_Than_High_Board_Number_Throws_Exception()
        {
            // ARRANGE
            Guid paramGuid = Guid.NewGuid();
            const int paramLowBoardNumber = 32;
            const int paramHighBoardNumber = 1;
            const string paramDescription = "Blue";

            IOwner paramOwner = new Owner(
                id: Guid.NewGuid(),
                code: "BRADGATE",
                name: "Bradgate",
                isClub: true);

            ISetPurpose paramSetPurpose = new SetPurpose(
                id: Guid.NewGuid(),
                code: "EVENT",
                name: "Events");

            ISetColour paramSetColour = new SetColour(
                id: Guid.NewGuid(),
                code: "LT-BLUE",
                name: "Light Blue");

            // ACT
            _ = new Set(
                id: paramGuid,
                lowBoardNumber: paramLowBoardNumber,
                highBoardNumber: paramHighBoardNumber,
                description: paramDescription,
                owner: paramOwner,
                setPurpose: paramSetPurpose,
                setColour: paramSetColour);

            // ASSERT
            Assert.Fail();
        }

        /// <summary>
        /// Tests the constructor null description throws exception.
        /// </summary>
        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void Test_Constructor_Null_Description_Throws_Exception()
        {
            // ARRANGE
            Guid paramGuid = Guid.NewGuid();
            const int paramLowBoardNumber = 1;
            const int paramHighBoardNumber = 32;

            IOwner paramOwner = new Owner(
                id: Guid.NewGuid(),
                code: "BRADGATE",
                name: "Bradgate",
                isClub: true);

            ISetPurpose paramSetPurpose = new SetPurpose(
                id: Guid.NewGuid(),
                code: "EVENT",
                name: "Events");

            ISetColour paramSetColour = new SetColour(
                id: Guid.NewGuid(),
                code: "LT-BLUE",
                name: "Light Blue");

            // ACT
            _ = new Set(
                id: paramGuid,
                lowBoardNumber: paramLowBoardNumber,
                highBoardNumber: paramHighBoardNumber,
                description: null,
                owner: paramOwner,
                setPurpose: paramSetPurpose,
                setColour: paramSetColour);
        }

        /// <summary>
        /// Tests the constructor empty description throws exception.
        /// </summary>
        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void Test_Constructor_Empty_Description_Throws_Exception()
        {
            // ARRANGE
            Guid paramGuid = Guid.NewGuid();
            const int paramLowBoardNumber = 1;
            const int paramHighBoardNumber = 32;

            IOwner paramOwner = new Owner(
                id: Guid.NewGuid(),
                code: "BRADGATE",
                name: "Bradgate",
                isClub: true);

            ISetPurpose paramSetPurpose = new SetPurpose(
                id: Guid.NewGuid(),
                code: "EVENT",
                name: "Events");

            ISetColour paramSetColour = new SetColour(
                id: Guid.NewGuid(),
                code: "LT-BLUE",
                name: "Light Blue");

            // ACT
            _ = new Set(
                id: paramGuid,
                lowBoardNumber: paramLowBoardNumber,
                highBoardNumber: paramHighBoardNumber,
                description: string.Empty,
                owner: paramOwner,
                setPurpose: paramSetPurpose,
                setColour: paramSetColour);
        }

        /// <summary>
        /// Tests the constructor null owner throws exception.
        /// </summary>
        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void Test_Constructor_Null_Owner_Throws_Exception()
        {
            // ARRANGE
            Guid paramGuid = Guid.NewGuid();
            const int paramLowBoardNumber = 1;
            const int paramHighBoardNumber = 32;
            const string paramDescription = "Blue";

            ISetPurpose paramSetPurpose = new SetPurpose(
                id: Guid.NewGuid(),
                code: "EVENT",
                name: "Events");

            ISetColour paramSetColour = new SetColour(
                id: Guid.NewGuid(),
                code: "LT-BLUE",
                name: "Light Blue");

            // ACT
            _ = new Set(
                id: paramGuid,
                lowBoardNumber: paramLowBoardNumber,
                highBoardNumber: paramHighBoardNumber,
                description: paramDescription,
                owner: null,
                setPurpose: paramSetPurpose,
                setColour: paramSetColour);
        }

        /// <summary>
        /// Tests the constructor null set purpose throws exception.
        /// </summary>
        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void Test_Constructor_Null_Set_Purpose_Throws_Exception()
        {
            // ARRANGE
            Guid paramGuid = Guid.NewGuid();
            const int paramLowBoardNumber = 1;
            const int paramHighBoardNumber = 32;
            const string paramDescription = "Blue";

            IOwner paramOwner = new Owner(
                id: Guid.NewGuid(),
                code: "BRADGATE",
                name: "Bradgate",
                isClub: true);

            ISetColour paramSetColour = new SetColour(
                id: Guid.NewGuid(),
                code: "LT-BLUE",
                name: "Light Blue");

            // ACT
            _ = new Set(
                id: paramGuid,
                lowBoardNumber: paramLowBoardNumber,
                highBoardNumber: paramHighBoardNumber,
                description: paramDescription,
                owner: paramOwner,
                setPurpose: null,
                setColour: paramSetColour);
        }

        /// <summary>
        /// Tests the constructor null set colour throws exception.
        /// </summary>
        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void Test_Constructor_Null_Set_Colour_Throws_Exception()
        {
            // ARRANGE
            Guid paramGuid = Guid.NewGuid();
            const int paramLowBoardNumber = 1;
            const int paramHighBoardNumber = 32;
            const string paramDescription = "Blue";

            IOwner paramOwner = new Owner(
                id: Guid.NewGuid(),
                code: "BRADGATE",
                name: "Bradgate",
                isClub: true);

            ISetPurpose paramSetPurpose = new SetPurpose(
                id: Guid.NewGuid(),
                code: "EVENT",
                name: "Events");

            // ACT
            _ = new Set(
                id: paramGuid,
                lowBoardNumber: paramLowBoardNumber,
                highBoardNumber: paramHighBoardNumber,
                description: paramDescription,
                owner: paramOwner,
                setPurpose: paramSetPurpose,
                setColour: null);
        }

        /// <summary>
        /// Tests the set constructor.
        /// </summary>
        [TestMethod]
        public void Test_Set_Constructor()
        {
            // ARRANGE
            Guid paramGuid = Guid.NewGuid();
            const int paramLowBoardNumber = 1;
            const int paramHighBoardNumber = 32;
            const string paramDescription = "Blue";

            IOwner paramOwner = new Owner(
                id: Guid.NewGuid(),
                code: "BRADGATE",
                name: "Bradgate",
                isClub: true);

            ISetPurpose paramSetPurpose = new SetPurpose(
                id: Guid.NewGuid(),
                code: "EVENT",
                name: "Events");

            ISetColour paramSetColour = new SetColour(
                id: Guid.NewGuid(),
                code: "LT-BLUE",
                name: "Light Blue");

            ISet set = new Set(
                id: paramGuid,
                lowBoardNumber: paramLowBoardNumber,
                highBoardNumber: paramHighBoardNumber,
                description: paramDescription,
                owner: paramOwner,
                setPurpose: paramSetPurpose,
                setColour: paramSetColour);

            // ACT
            ISet newSet = new Set(set);

            // ASSERT
            Assert.AreEqual(set.Id, newSet.Id);
            Assert.AreEqual(set.LowBoardNumber, newSet.LowBoardNumber);
            Assert.AreEqual(set.HighBoardNumber, newSet.HighBoardNumber);
            Assert.AreEqual(set.Description, newSet.Description);
            Assert.AreSame(set.Owner, newSet.Owner);
            Assert.AreSame(set.SetPurpose, newSet.SetPurpose);
            Assert.AreSame(set.SetColour, newSet.SetColour);
        }

        /// <summary>
        /// Tests the set constructor null set throws exception.
        /// </summary>
        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void Test_Set_Constructor_Null_Set_Throws_Exception()
        {
            // ACT
            _ = new Set(
                set: null);

            // ASSERT
            Assert.Fail();
        }
    }
}