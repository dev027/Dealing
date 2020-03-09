// <copyright file="ConstructorTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Data.Dtos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Data.Tests.Dtos.CardDtoTests
{
    /// <summary>
    /// Test constructor for <see cref="CardDto" />.
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
            Guid paramSuitId = Guid.NewGuid();
            Guid paramRankId = Guid.NewGuid();

            // ACT
            CardDto dto = new CardDto(
                id: paramId,
                suitId: paramSuitId,
                rankId: paramRankId);

            // ASSERT
            Assert.AreEqual(paramId, dto.Id);
            Assert.AreEqual(paramSuitId, dto.SuitId);
            Assert.AreEqual(paramRankId, dto.RankId);
        }
    }
}