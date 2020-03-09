// <copyright file="ConstructorTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Data.Dtos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Data.Tests.Dtos.EventSetDtoTests
{
    /// <summary>
    /// Test constructor for <see cref="EventSetDto" />.
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
            Guid paramEventId = Guid.NewGuid();
            Guid paramSetId = Guid.NewGuid();
            Guid paramDealerId = Guid.NewGuid();
            DateTime paramDealt = DateTime.Today;
            const bool paramIsBoardsReturnedOutOfSequence = true;

            // ACT
            EventSetDto dto = new EventSetDto(
                id: paramId,
                eventId: paramEventId,
                setId: paramSetId,
                dealerId: paramDealerId,
                dealt: paramDealt,
                isBoardsReturnedOutOfSequence: paramIsBoardsReturnedOutOfSequence);

            // ASSERT
            Assert.AreEqual(paramId, dto.Id);
            Assert.AreEqual(paramEventId, dto.EventId);
            Assert.AreEqual(paramSetId, dto.SetId);
            Assert.AreEqual(paramDealerId, dto.DealerId);
            Assert.AreEqual(paramDealt, dto.Dealt);
            Assert.AreEqual(paramIsBoardsReturnedOutOfSequence, dto.IsBoardsReturnedOutOfSequence);
        }
    }
}