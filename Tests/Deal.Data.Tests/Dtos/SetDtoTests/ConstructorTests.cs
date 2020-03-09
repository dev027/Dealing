// <copyright file="ConstructorTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Data.Dtos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Data.Tests.Dtos.SetDtoTests
{
    /// <summary>
    /// Test constructor for <see cref="SetDto" />.
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
            Guid paramOwnerId = Guid.NewGuid();
            Guid paramSetPurposeId = Guid.NewGuid();
            Guid paramColourId = Guid.NewGuid();
            const int paramLowBoardNumber = 1;
            const int paramHighBoardNumber = 32;
            const string paramDescription = "Description";

            // ACT
            SetDto dto = new SetDto(
                id: paramId,
                ownerId: paramOwnerId,
                setPurposeId: paramSetPurposeId,
                setColourId: paramColourId,
                lowBoardNumber: paramLowBoardNumber,
                highBoardNumber: paramHighBoardNumber,
                description: paramDescription);

            // ASSERT
            Assert.AreEqual(paramId, dto.Id);
            Assert.AreEqual(paramOwnerId, dto.OwnerId);
            Assert.AreEqual(paramSetPurposeId, dto.SetPurposeId);
            Assert.AreEqual(paramColourId, dto.SetColourId);
            Assert.AreEqual(paramLowBoardNumber, dto.LowBoardNumber);
            Assert.AreEqual(paramHighBoardNumber, dto.HighBoardNumber);
            Assert.AreEqual(paramDescription, dto.Description);
        }
    }
}