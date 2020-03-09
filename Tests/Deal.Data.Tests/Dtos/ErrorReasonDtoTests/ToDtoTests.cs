// <copyright file="ToDtoTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Data.Dtos;
using Deal.Domain.DomainObjects.ErrorReasonGroups;
using Deal.Domain.DomainObjects.ErrorReasons;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Data.Tests.Dtos.ErrorReasonDtoTests
{
    /// <summary>
    /// Test <see cref="ErrorReasonDto.ToDto"/>.
    /// </summary>
    [TestClass]
    public class ToDtoTests
    {
        /// <summary>
        /// Tests method with valid values.
        /// </summary>
        [TestMethod]
        public void Test_Passing_Valid_Values()
        {
            // ARRANGE
            IErrorReason errorReason = new ErrorReason(
                id: Guid.NewGuid(),
                code: "MIS-READ",
                name: "Misread",
                errorReasonGroup: new ErrorReasonGroup(
                    id: Guid.NewGuid(),
                    code: "CARD",
                    name: "Card"));

            // ACT
            ErrorReasonDto errorReasonDto = ErrorReasonDto.ToDto(errorReason);

            // ASSERT
            Assert.AreEqual(errorReason.Id, errorReasonDto.Id);
            Assert.AreEqual(errorReason.Code, errorReasonDto.Code);
            Assert.AreEqual(errorReason.Name, errorReasonDto.Name);
            Assert.AreEqual(errorReason.ErrorReasonGroup.Id, errorReasonDto.ErrorReasonGroupId);
        }

        /// <summary>
        /// Tests passing null card throws exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Passing_Null_Card_Throws_Exception()
        {
            // ACT
            _ = ErrorReasonDto.ToDto(null);
        }
    }
}