// <copyright file="ConstructorTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Data.Dtos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Data.Tests.Dtos.SetDealErrorDtoTests
{
    /// <summary>
    /// Test constructor for <see cref="SetDealErrorDto" />.
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
            Guid paramEventSetId = Guid.NewGuid();
            Guid paramReasonErrorId = Guid.NewGuid();
            const int paramNorthCount = 1;
            const int paramEastCount = 2;
            const int paramWestCount = 3;
            const int paramSouthCount = 4;

            // ACT
            SetDealErrorDto dto = new SetDealErrorDto(
                id: paramId,
                eventSetId: paramEventSetId,
                errorReasonId: paramReasonErrorId,
                northCount: paramNorthCount,
                eastCount: paramEastCount,
                westCount: paramWestCount,
                southCount: paramSouthCount);

            // ASSERT
            Assert.AreEqual(paramId, dto.Id);
            Assert.AreEqual(paramEventSetId, dto.EventSetId);
            Assert.AreEqual(paramReasonErrorId, dto.ErrorReasonId);
            Assert.AreEqual(paramNorthCount, dto.NorthCount);
            Assert.AreEqual(paramEastCount, dto.EastCount);
            Assert.AreEqual(paramWestCount, dto.WestCount);
            Assert.AreEqual(paramSouthCount, dto.SouthCount);
        }
    }
}