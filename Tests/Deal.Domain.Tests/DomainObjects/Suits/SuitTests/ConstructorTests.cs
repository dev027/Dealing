// <copyright file="ConstructorTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Domain.DomainObjects.Suits;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Domain.Tests.DomainObjects.Suits.SuitTests
{
    /// <summary>
    /// Test the constructor for <see cref="Suit"/>.
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
            const string paramCode = "S";
            const string paramName = "Spades";
            const short paramSortOrder = 1;

            // ACT
            ISuit suit = new Suit(
                id: paramGuid,
                code: paramCode,
                name: paramName,
                sortOrder: paramSortOrder);

            // ASSERT
            Assert.AreEqual(paramGuid, suit.Id);
            Assert.AreEqual(paramCode, suit.Code);
            Assert.AreEqual(paramName, suit.Name);
            Assert.AreEqual(paramSortOrder, suit.SortOrder);
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
            const string paramName = "Spades";
            const short paramSortOrder = 1;

            // ACT
            _ = new Suit(
                id: paramGuid,
                code: null,
                name: paramName,
                sortOrder: paramSortOrder);

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
            const string paramCode = "S";
            const short paramSortOrder = 1;

            // ACT
            _ = new Suit(
                id: paramGuid,
                code: paramCode,
                name: null,
                sortOrder: paramSortOrder);

            // ASSERT
            Assert.Fail();
        }
    }
}