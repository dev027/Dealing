// <copyright file="ConstructorTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Domain.DomainObjects.Organisers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Domain.Tests.DomainObjects.Organisers.OrganiserTests
{
    /// <summary>
    /// Test the constructor for <see cref="Organiser"/>.
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
            const string paramCode = "CBC";
            const string paramName = "County Bridge Club";

            // ACT
            IOrganiser organiser = new Organiser(
                id: paramGuid,
                code: paramCode,
                name: paramName);

            // ASSERT
            Assert.AreEqual(paramGuid, organiser.Id);
            Assert.AreEqual(paramCode, organiser.Code);
            Assert.AreEqual(paramName, organiser.Name);
        }

        /// <summary>
        /// Tests the constructor null code throws exception.
        /// </summary>
        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void Test_Constructor_Null_Code_Throws_Exception()
        {
            // ARRANGE
            Guid paramGuid = Guid.NewGuid();
            const string paramName = "County Bridge Club";

            // ACT
            _ = new Organiser(
                id: paramGuid,
                code: null,
                name: paramName);

            // ASSERT
            Assert.Fail();
        }

        /// <summary>
        /// Tests the constructor null name throws exception.
        /// </summary>
        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void Test_Constructor_Null_Name_Throws_Exception()
        {
            // ARRANGE
            Guid paramGuid = Guid.NewGuid();
            const string paramCode = "CBC";

            // ACT
            _ = new Organiser(
                id: paramGuid,
                code: paramCode,
                name: null);

            // ASSERT
            Assert.Fail();
        }
    }
}