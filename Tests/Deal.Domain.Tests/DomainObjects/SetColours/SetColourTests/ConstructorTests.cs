// <copyright file="ConstructorTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Domain.DomainObjects.SetColours;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Domain.Tests.DomainObjects.SetColours.SetColourTests
{
    /// <summary>
    /// Test the constructor for <see cref="SetColours"/>.
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
            const string paramCode = "RED";
            const string paramName = "Red";

            // ACT
            ISetColour setColour = new SetColour(
                id: paramGuid,
                code: paramCode,
                name: paramName);

            // ASSERT
            Assert.AreEqual(paramGuid, setColour.Id);
            Assert.AreEqual(paramCode, setColour.Code);
            Assert.AreEqual(paramName, setColour.Name);
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
            const string paramName = "Red";

            // ACT
            _ = new SetColour(
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
            const string paramCode = "RED";

            // ACT
            _ = new SetColour(
                id: paramGuid,
                code: paramCode,
                name: null);

            // ASSERT
            Assert.Fail();
        }
    }
}