// <copyright file="ConstructorTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Data.Dtos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Data.Tests.Dtos.ErrorReasonDtoTests
{
    /// <summary>
    /// Test constructor for <see cref="ErrorReasonDto" />.
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
            Guid paramId = Guid.NewGuid();
            const string paramCode = "MISREAD";
            const string paramName = "Misread card";
            Guid paramErrorReasonGroupId = Guid.NewGuid();

            // ACT
            ErrorReasonDto dto = new ErrorReasonDto(
                id: paramId,
                code: paramCode,
                name: paramName,
                errorReasonGroupId: paramErrorReasonGroupId);

            // ASSERT
            Assert.AreEqual(paramId, dto.Id);
            Assert.AreEqual(paramCode, dto.Code);
            Assert.AreEqual(paramName, dto.Name);
            Assert.AreEqual(paramErrorReasonGroupId, dto.ErrorReasonGroupId);
        }
    }
}