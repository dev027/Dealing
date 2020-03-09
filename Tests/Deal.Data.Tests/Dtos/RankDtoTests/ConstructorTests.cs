// <copyright file="ConstructorTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Data.Dtos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Data.Tests.Dtos.RankDtoTests
{
    /// <summary>
    /// Test constructor for <see cref="RankDto" />.
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
            const string paramCode = "A";
            const string paramName = "Ace";
            const short paramSortOrder = 1;

            // ACT
            RankDto dto = new RankDto(
                id: paramId,
                code: paramCode,
                name: paramName,
                sortOrder: paramSortOrder);

            // ASSERT
            Assert.AreEqual(paramId, dto.Id);
            Assert.AreEqual(paramCode, dto.Code);
            Assert.AreEqual(paramName, dto.Name);
            Assert.AreEqual(paramSortOrder, dto.SortOrder);
        }
    }
}