// <copyright file="ConstructorTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Domain.DomainObjects.Owners;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Domain.Tests.DomainObjects.Owners.OwnerTests
{
    /// <summary>
    /// Test the constructor for <see cref="Owner"/>.
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
            const bool paramIsClub = true;

            // ACT
            IOwner owner = new Owner(
                id: paramGuid,
                code: paramCode,
                name: paramName,
                isClub: paramIsClub);

            // ASSERT
            Assert.AreEqual(paramGuid, owner.Id);
            Assert.AreEqual(paramCode, owner.Code);
            Assert.AreEqual(paramName, owner.Name);
            Assert.AreEqual(paramIsClub, owner.IsClub);
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
            const bool paramIsClub = true;

            // ACT
            _ = new Owner(
                id: paramGuid,
                code: null,
                name: paramName,
                isClub: paramIsClub);

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
            const bool paramIsClub = true;

            // ACT
            _ = new Owner(
                id: paramGuid,
                code: paramCode,
                name: null,
                isClub: paramIsClub);

            // ASSERT
            Assert.Fail();
        }
    }
}