// <copyright file="ConstructorTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Domain.DomainObjects.SetPurposes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Domain.Tests.DomainObjects.SetPurposes.SetPurposeTests
{
    /// <summary>
    /// Test the constructor for <see cref="SetPurpose"/>.
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
            const string paramCode = "TEACHING";
            const string paramName = "Teaching";

            // ACT
            ISetPurpose suit = new SetPurpose(
                id: paramGuid,
                code: paramCode,
                name: paramName);

            // ASSERT
            Assert.AreEqual(paramGuid, suit.Id);
            Assert.AreEqual(paramCode, suit.Code);
            Assert.AreEqual(paramName, suit.Name);
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
            const string paramName = "Teaching";

            // ACT
            _ = new SetPurpose(
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
            const string paramCode = "TEACHING";

            // ACT
            _ = new SetPurpose(
                id: paramGuid,
                code: paramCode,
                name: null);

            // ASSERT
            Assert.Fail();
        }
    }
}