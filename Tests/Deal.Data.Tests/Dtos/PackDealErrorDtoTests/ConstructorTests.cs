// <copyright file="ConstructorTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Data.Dtos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Data.Tests.Dtos.PackDealErrorDtoTests
{
    /// <summary>
    /// Test constructor for <see cref="PackDealErrorDto" />.
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
            Guid paramPackId = Guid.NewGuid();
            Guid paramErrorReasonId = Guid.NewGuid();
            Guid paramActualCardId = Guid.NewGuid();
            Guid paramClaimedCardId = Guid.NewGuid();

            // ACT
            PackDealErrorDto dto = new PackDealErrorDto(
                id: paramId,
                eventSetId: paramEventSetId,
                packId: paramPackId,
                errorReasonId: paramErrorReasonId,
                actualCardId: paramActualCardId,
                claimedCardId: paramClaimedCardId);

            // ASSERT
            Assert.AreEqual(paramId, dto.Id);
            Assert.AreEqual(paramEventSetId, dto.EventSetId);
            Assert.AreEqual(paramPackId, dto.PackId);
            Assert.AreEqual(paramErrorReasonId, dto.ErrorReasonId);
            Assert.AreEqual(paramActualCardId, dto.ActualCardId);
            Assert.AreEqual(paramClaimedCardId, dto.ClaimedCardId);
        }
    }
}