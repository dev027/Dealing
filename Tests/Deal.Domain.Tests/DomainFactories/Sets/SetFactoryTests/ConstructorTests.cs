// <copyright file="ConstructorTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using Deal.Domain.DomainFactories.Sets;
using Deal.Domain.DomainObjects.Owners;
using Deal.Domain.DomainObjects.SetColours;
using Deal.Domain.DomainObjects.SetPurposes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Domain.Tests.DomainFactories.Sets.SetFactoryTests
{
    /// <summary>
    /// Test the constructor for <see cref="SetFactory"/>.
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
            IList<IOwner> paramOwners = new List<IOwner>();
            IList<ISetPurpose> paramSetPurposes = new List<ISetPurpose>();
            IList<ISetColour> paramSetColours = new List<ISetColour>();

            // ACT
            SetFactory setFactory = new SetFactory(
                owners: paramOwners,
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
            IList<ISetPurpose> paramSetPurposes = new List<ISetPurpose>();
            IList<ISetColour> paramSetColours = new List<ISetColour>();

            // ACT
            _ = new SetFactory(
                owners: null,
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
            IList<ISetColour> paramSetColours = new List<ISetColour>();

            // ACT
            _ = new SetFactory(
                owners: paramOwners,
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
            IList<ISetPurpose> paramSetPurposes = new List<ISetPurpose>();

            // ACT
            _ = new SetFactory(
                owners: paramOwners,
                setPurposes: paramSetPurposes,
                setColours: null);

            // ASSERT
            Assert.Fail();
        }
    }
}