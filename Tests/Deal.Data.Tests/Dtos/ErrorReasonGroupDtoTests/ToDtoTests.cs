// <copyright file="ToDtoTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Data.Dtos;
using Deal.Domain.DomainObjects.ErrorReasonGroups;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Data.Tests.Dtos.ErrorReasonGroupDtoTests
{
    /// <summary>
    /// Test <see cref="ErrorReasonGroupDto.ToDto"/>.
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
            IErrorReasonGroup errorReasonGroup = new ErrorReasonGroup(
                Guid.NewGuid(),
                "CARD",
                "Card");

            // ACT
            ErrorReasonGroupDto errorReasonGroupDto = ErrorReasonGroupDto.ToDto(errorReasonGroup);

            // ASSERT
            Assert.AreEqual(errorReasonGroup.Id, errorReasonGroupDto.Id);
            Assert.AreEqual(errorReasonGroup.Code, errorReasonGroupDto.Code);
            Assert.AreEqual(errorReasonGroup.Name, errorReasonGroupDto.Name);
        }

        /// <summary>
        /// Tests passing null card throws exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Passing_Null_Card_Throws_Exception()
        {
            // ACT
            _ = ErrorReasonGroupDto.ToDto(null);
        }
    }
}