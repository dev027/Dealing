// <copyright file="ConstructorTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Domain.DomainObjects.ErrorReasonGroups;
using Deal.Domain.DomainObjects.ErrorReasons;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Domain.Tests.DomainObjects.ErrorReasons.ErrorReasonTests
{
    /// <summary>
    /// Test the constructor for <see cref="ErrorReason"/>.
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
            const string paramCode = "INVERTED";
            const string paramName = "Inverted Card";

            IErrorReasonGroup paramErrorReasonGroup = new ErrorReasonGroup(
                id: Guid.NewGuid(),
                code: "SET",
                name: "Set");

            // ACT
            IErrorReason errorReason = new ErrorReason(
                id: paramGuid,
                code: paramCode,
                name: paramName,
                errorReasonGroup: paramErrorReasonGroup);

            // ASSERT
            Assert.AreEqual(paramGuid, errorReason.Id);
            Assert.AreEqual(paramCode, errorReason.Code);
            Assert.AreEqual(paramName, errorReason.Name);
            Assert.AreSame(paramErrorReasonGroup, errorReason.ErrorReasonGroup);
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
            const string paramName = "Inverted Card";

            IErrorReasonGroup paramErrorReasonGroup = new ErrorReasonGroup(
                id: Guid.NewGuid(),
                code: "SET",
                name: "Set");

            // ACT
            _ = new ErrorReason(
                id: paramGuid,
                code: null,
                name: paramName,
                errorReasonGroup: paramErrorReasonGroup);

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
            const string paramCode = "INVERTED";

            IErrorReasonGroup paramErrorReasonGroup = new ErrorReasonGroup(
                id: Guid.NewGuid(),
                code: "SET",
                name: "Set");

            // ACT
            _ = new ErrorReason(
                id: paramGuid,
                code: paramCode,
                name: null,
                errorReasonGroup: paramErrorReasonGroup);

            // ASSERT
            Assert.Fail();
        }

        /// <summary>
        /// Tests the constructor null error reason group throws exception.
        /// </summary>
        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void Test_Constructor_Null_Error_Reason_Group_Throws_Exception()
        {
            // ARRANGE
            Guid paramGuid = Guid.NewGuid();
            const string paramCode = "INVERTED";
            const string paramName = "Inverted Card";

            // ACT
            _ = new ErrorReason(
                id: paramGuid,
                code: paramCode,
                name: paramName,
                errorReasonGroup: null);

            // ASSERT
            Assert.Fail();
        }
    }
}