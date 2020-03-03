// <copyright file="ConstructorTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using Deal.Domain.DomainFactories.Sets;
using Deal.Domain.DomainObjects.Owners;
using Deal.Domain.DomainObjects.PackColours;
using Deal.Domain.DomainObjects.SetColours;
using Deal.Domain.DomainObjects.SetPurposes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Domain.Tests.DomainFactories.Sets.SetFactoryTests
{
    /// <summary>
    /// Test the constructor for <see cref="SetWithPacksFactory"/>.
    /// </summary>
    [TestClass]
    public class ConstructorTests
    {
        #region Tests

        /// <summary>
        /// Tests the basic constructor.
        /// </summary>
        [TestMethod]
        public void Test_Basic_Constructor()
        {
            // ARRANGE
            IList<IOwner> paramOwners = new List<IOwner>();
            IList<IPackColour> paramPackColours = CreatePackColours();
            IList<ISetPurpose> paramSetPurposes = new List<ISetPurpose>();
            IList<ISetColour> paramSetColours = new List<ISetColour>();

            // ACT
            SetWithPacksFactory setFactory = new SetWithPacksFactory(
                owners: paramOwners,
                packColours: paramPackColours,
                setPurposes: paramSetPurposes,
                setColours: paramSetColours);

            // ASSERT
            Assert.IsNotNull(setFactory);
        }

        /// <summary>
        /// Tests the constructor null owners throws exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Constructor_Null_Owners_Throws_Exception()
        {
            // ARRANGE
            IList<IPackColour> paramPackColours = CreatePackColours();
            IList<ISetPurpose> paramSetPurposes = new List<ISetPurpose>();
            IList<ISetColour> paramSetColours = new List<ISetColour>();

            // ACT
            _ = new SetWithPacksFactory(
                owners: null,
                packColours: paramPackColours,
                setPurposes: paramSetPurposes,
                setColours: paramSetColours);

            // ASSERT
            Assert.Fail();
        }

        /// <summary>
        /// Tests the constructor null pack colours throws exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Constructor_Null_PackColours_Throws_Exception()
        {
            // ARRANGE
            IList<IOwner> paramOwners = new List<IOwner>();
            IList<ISetPurpose> paramSetPurposes = new List<ISetPurpose>();
            IList<ISetColour> paramSetColours = new List<ISetColour>();

            // ACT
            _ = new SetWithPacksFactory(
                owners: paramOwners,
                packColours: null,
                setPurposes: paramSetPurposes,
                setColours: paramSetColours);

            // ASSERT
            Assert.Fail();
        }

        /// <summary>
        /// Tests the constructor null set purposes throws exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Constructor_Null_SetPurposes_Throws_Exception()
        {
            // ARRANGE
            IList<IOwner> paramOwners = new List<IOwner>();
            IList<IPackColour> paramPackColours = CreatePackColours();
            IList<ISetColour> paramSetColours = new List<ISetColour>();

            // ACT
            _ = new SetWithPacksFactory(
                owners: paramOwners,
                packColours: paramPackColours,
                setPurposes: null,
                setColours: paramSetColours);

            // ASSERT
            Assert.Fail();
        }

        /// <summary>
        /// Tests the constructor null set colours throws exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Constructor_Null_SetColours_Throws_Exception()
        {
            // ARRANGE
            IList<IOwner> paramOwners = new List<IOwner>();
            IList<IPackColour> paramPackColours = new List<IPackColour>();
            IList<ISetPurpose> paramSetPurposes = new List<ISetPurpose>();

            // ACT
            _ = new SetWithPacksFactory(
                owners: paramOwners,
                packColours: paramPackColours,
                setPurposes: paramSetPurposes,
                setColours: null);

            // ASSERT
            Assert.Fail();
        }

        #endregion Tests

        #region Test Helpers

        private static IList<IPackColour> CreatePackColours()
        {
            return new List<IPackColour>
            {
                new PackColour(id: Guid.NewGuid(), code: "B", colour: "Blue"),
                new PackColour(id: Guid.NewGuid(), code: "R", colour: "Red"),
            };
        }

        #endregion Test Helpers
    }
}