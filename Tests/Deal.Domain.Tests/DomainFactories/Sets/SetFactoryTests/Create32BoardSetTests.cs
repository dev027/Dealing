// <copyright file="Create32BoardSetTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using Deal.Domain.DomainFactories.Sets;
using Deal.Domain.DomainObjects.Owners;
using Deal.Domain.DomainObjects.SetColours;
using Deal.Domain.DomainObjects.SetPurposes;
using Deal.Domain.DomainObjects.Sets;
using Deal.Domain.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Domain.Tests.DomainFactories.Sets.SetFactoryTests
{
    /// <summary>
    /// Test for <see cref="SetFactory.Create32BoardSet"/>.
    /// </summary>
    [TestClass]
    public class Create32BoardSetTests
    {
        /// <summary>
        /// Tests the create set with valid details.
        /// </summary>
        [TestMethod]
        public void Test_Create_Set_With_Valid_Details()
        {
            // ARRANGE
            const string paramOwnerCode = "OWNER2";
            const string paramSetPurposeCode = "SET_PURPOSE2";
            const string paramSetColourCode = "SET_COLOUR2";
            const string paramDescription = "My Description";
            ISetFactory setFactory = CreateSetFactory();

            // ACT
            ISet set = setFactory.Create32BoardSet(
                ownerCode: paramOwnerCode,
                setPurposeCode: paramSetPurposeCode,
                setColourCode: paramSetColourCode,
                description: paramDescription);

            // ASSERT
            Assert.IsNotNull(set);
            Assert.AreEqual(paramOwnerCode, set.Owner.Code);
            Assert.AreEqual(paramSetPurposeCode, set.SetPurpose.Code);
            Assert.AreEqual(paramSetColourCode, set.SetColour.Code);
            Assert.AreEqual(paramDescription, set.Description);
            Assert.AreEqual(1, set.LowBoardNumber);
            Assert.AreEqual(32, set.HighBoardNumber);
            Assert.AreNotEqual(Guid.Empty, set.Id);
        }

        /// <summary>
        /// Tests the create set with unknown owner code throws exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(SetFactoryException))]
        public void Test_Create_Set_With_Unknown_Owner_Code_Throws_Exception()
        {
            // ARRANGE
            const string paramOwnerCode = "UNKNOWN";
            const string paramSetPurposeCode = "SET_PURPOSE2";
            const string paramSetColourCode = "SET_COLOUR2";
            const string paramDescription = "My Description";
            ISetFactory setFactory = CreateSetFactory();

            // ACT
            _ = setFactory.Create32BoardSet(
                ownerCode: paramOwnerCode,
                setPurposeCode: paramSetPurposeCode,
                setColourCode: paramSetColourCode,
                description: paramDescription);

            // ASSERT
            Assert.Fail();
        }

        /// <summary>
        /// Tests the create set with unknown set purpose code throws exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(SetFactoryException))]
        public void Test_Create_Set_With_Unknown_Set_Purpose_Code_Throws_Exception()
        {
            // ARRANGE
            const string paramOwnerCode = "OWNER2";
            const string paramSetPurposeCode = "UNKNOWN";
            const string paramSetColourCode = "SET_COLOUR2";
            const string paramDescription = "My Description";
            ISetFactory setFactory = CreateSetFactory();

            // ACT
            _ = setFactory.Create32BoardSet(
                ownerCode: paramOwnerCode,
                setPurposeCode: paramSetPurposeCode,
                setColourCode: paramSetColourCode,
                description: paramDescription);

            // ASSERT
            Assert.Fail();
        }

        /// <summary>
        /// Tests the create set with unknown set colour code throws exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(SetFactoryException))]
        public void Test_Create_Set_With_Unknown_Set_Colour_Code_Throws_Exception()
        {
            // ARRANGE
            const string paramOwnerCode = "OWNER2";
            const string paramSetPurposeCode = "SET_PURPOSE2";
            const string paramSetColourCode = "UNKNOWN";
            const string paramDescription = "My Description";
            ISetFactory setFactory = CreateSetFactory();

            // ACT
            _ = setFactory.Create32BoardSet(
                ownerCode: paramOwnerCode,
                setPurposeCode: paramSetPurposeCode,
                setColourCode: paramSetColourCode,
                description: paramDescription);

            // ASSERT
            Assert.Fail();
        }

        /// <summary>
        /// Tests the create set with null description throws exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Create_Set_With_Null_Description_Throws_Exception()
        {
            // ARRANGE
            const string paramOwnerCode = "OWNER2";
            const string paramSetPurposeCode = "SET_PURPOSE2";
            const string paramSetColourCode = "SET_COLOUR2";
            ISetFactory setFactory = CreateSetFactory();

            // ACT
            _ = setFactory.Create32BoardSet(
                ownerCode: paramOwnerCode,
                setPurposeCode: paramSetPurposeCode,
                setColourCode: paramSetColourCode,
                description: null);

            // ASSERT
            Assert.Fail();
        }

        /// <summary>
        /// Tests the create set with empty description throws exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Create_Set_With_Empty_Description_Throws_Exception()
        {
            // ARRANGE
            const string paramOwnerCode = "OWNER2";
            const string paramSetPurposeCode = "SET_PURPOSE2";
            const string paramSetColourCode = "SET_COLOUR2";
            ISetFactory setFactory = CreateSetFactory();

            // ACT
            _ = setFactory.Create32BoardSet(
                ownerCode: paramOwnerCode,
                setPurposeCode: paramSetPurposeCode,
                setColourCode: paramSetColourCode,
                description: string.Empty);

            // ASSERT
            Assert.Fail();
        }

        /// <summary>
        /// Tests the create set with null owner code throws exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Create_Set_With_Null_Owner_Code_Throws_Exception()
        {
            // ARRANGE
            const string paramSetPurposeCode = "SET_PURPOSE2";
            const string paramSetColourCode = "SET_COLOUR2";
            const string paramDescription = "My Description";
            ISetFactory setFactory = CreateSetFactory();

            // ACT
            _ = setFactory.Create32BoardSet(
                ownerCode: null,
                setPurposeCode: paramSetPurposeCode,
                setColourCode: paramSetColourCode,
                description: paramDescription);

            // ASSERT
            Assert.Fail();
        }

        /// <summary>
        /// Tests the create set with null set purpose code throws exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Create_Set_With_Null_Set_Purpose_Code_Throws_Exception()
        {
            // ARRANGE
            const string paramOwnerCode = "OWNER2";
            const string paramSetColourCode = "SET_COLOUR2";
            const string paramDescription = "My Description";
            ISetFactory setFactory = CreateSetFactory();

            // ACT
            _ = setFactory.Create32BoardSet(
                ownerCode: paramOwnerCode,
                setPurposeCode: null,
                setColourCode: paramSetColourCode,
                description: paramDescription);

            // ASSERT
            Assert.Fail();
        }

        /// <summary>
        /// Tests the create set with null set colour code throws exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Create_Set_With_Null_Set_Colour_Code_Throws_Exception()
        {
            // ARRANGE
            const string paramOwnerCode = "OWNER2";
            const string paramSetPurposeCode = "SET_PURPOSE2";
            const string paramDescription = "My Description";
            ISetFactory setFactory = CreateSetFactory();

            // ACT
            _ = setFactory.Create32BoardSet(
                ownerCode: paramOwnerCode,
                setPurposeCode: paramSetPurposeCode,
                setColourCode: null,
                description: paramDescription);

            // ASSERT
            Assert.Fail();
        }

        private static ISetFactory CreateSetFactory()
        {
            IList<IOwner> owners = CreateOwners();
            IList<ISetPurpose> setPurposes = CreateSetPurposes();
            IList<ISetColour> setColours = CreateSetColours();

            return new SetFactory(
                owners: owners,
                setPurposes: setPurposes,
                setColours: setColours);
        }

        private static IList<IOwner> CreateOwners()
        {
            return new List<IOwner>
            {
                new Owner(
                    id: Guid.NewGuid(),
                    code: "OWNER1",
                    name: "Owner 1",
                    isClub: true),
                new Owner(
                    id: Guid.NewGuid(),
                    code: "OWNER2",
                    name: "Owner 2",
                    isClub: true),
                new Owner(
                    id: Guid.NewGuid(),
                    code: "OWNER3",
                    name: "Owner 3",
                    isClub: true)
            };
        }

        private static IList<ISetPurpose> CreateSetPurposes()
        {
            return new List<ISetPurpose>
            {
                new SetPurpose(
                    id: Guid.NewGuid(),
                    code: "SET_PURPOSE1",
                    name: "Set Purpose 1"),
                new SetPurpose(
                    id: Guid.NewGuid(),
                    code: "SET_PURPOSE2",
                    name: "Set Purpose 2"),
                new SetPurpose(
                    id: Guid.NewGuid(),
                    code: "SET_PURPOSE3",
                    name: "Set Purpose 3"),
            };
        }

        private static IList<ISetColour> CreateSetColours()
        {
            return new List<ISetColour>
            {
                new SetColour(
                    id: Guid.NewGuid(),
                    code: "SET_COLOUR1",
                    name: "Set Colour 1"),
                new SetColour(
                    id: Guid.NewGuid(),
                    code: "SET_COLOUR2",
                    name: "Set Colour 2"),
                new SetColour(
                    id: Guid.NewGuid(),
                    code: "SET_COLOUR3",
                    name: "Set Colour 3")
            };
        }
    }
}