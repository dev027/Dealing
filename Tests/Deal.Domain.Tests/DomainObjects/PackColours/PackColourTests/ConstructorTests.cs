// <copyright file="ConstructorTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Domain.DomainObjects.PackColours;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Domain.Tests.DomainObjects.PackColours.PackColourTests
{
    /// <summary>
    /// Test the constructor for <see cref="PackColour"/>.
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
            const string paramCode = "B";
            const string paramColour = "Blue";

            // ACT
            IPackColour packColour = new PackColour(
                paramGuid,
                paramCode,
                paramColour);

            // ASSERT
            Assert.AreEqual(paramGuid, packColour.Id);
            Assert.AreEqual(paramCode, packColour.Code);
            Assert.AreEqual(paramColour, packColour.Colour);
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
            const string paramColour = "Blue";

            // ACT
            _ = new PackColour(
                id: paramGuid,
                code: null,
                colour: paramColour);

            // ASSERT
            Assert.Fail();
        }

        /// <summary>
        /// Tests the constructor null colour throws exception.
        /// </summary>
        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void Test_Constructor_Null_Colour_Throws_Exception()
        {
            // ARRANGE
            Guid paramGuid = Guid.NewGuid();
            const string paramCode = "B";

            // ACT
            _ = new PackColour(
                id: paramGuid,
                code: paramCode,
                colour: null);

            // ASSERT
            Assert.Fail();
        }
    }
}