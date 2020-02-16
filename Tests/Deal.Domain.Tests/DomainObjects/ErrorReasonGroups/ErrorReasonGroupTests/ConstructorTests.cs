// <copyright file="ConstructorTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Domain.DomainObjects.ErrorReasonGroups;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Domain.Tests.DomainObjects.ErrorReasonGroups.ErrorReasonGroupTests
{
    /// <summary>
    /// Test the constructor for <see cref="ErrorReasonGroup"/>.
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
            const string paramCode = "CARD";
            const string paramName = "Card";

            // ACT
            IErrorReasonGroup errorReasonGroup = new ErrorReasonGroup(
                id: paramGuid,
                code: paramCode,
                name: paramName);

            // ASSERT
            Assert.AreEqual(paramGuid, errorReasonGroup.Id);
            Assert.AreEqual(paramCode, errorReasonGroup.Code);
            Assert.AreEqual(paramName, errorReasonGroup.Name);
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
            const string paramName = "Card";

            // ACT
            _ = new ErrorReasonGroup(
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
            const string paramCode = "CARD";

            // ACT
            _ = new ErrorReasonGroup(
                id: paramGuid,
                code: paramCode,
                name: null);

            // ASSERT
            Assert.Fail();
        }
    }
}