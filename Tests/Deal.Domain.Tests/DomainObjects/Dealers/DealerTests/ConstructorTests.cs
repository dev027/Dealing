// <copyright file="ConstructorTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Domain.DomainObjects.Dealers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Domain.Tests.DomainObjects.Dealers.DealerTests
{
    /// <summary>
    /// Test the constructor for <see cref="Dealer"/>.
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
            const string paramName = "Steve";

            // ACT
            IDealer rank = new Dealer(
                id: paramGuid,
                name: paramName);

            // ASSERT
            Assert.AreEqual(paramGuid, rank.Id);
            Assert.AreEqual(paramName, rank.Name);
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

            // ACT
            _ = new Dealer(
                id: paramGuid,
                name: null);

            // ASSERT
            Assert.Fail();
        }
    }
}