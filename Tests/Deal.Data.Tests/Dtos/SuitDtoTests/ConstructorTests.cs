// <copyright file="ConstructorTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Data.Dtos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Data.Tests.Dtos.SuitDtoTests
{
    /// <summary>
    /// Test constructor for <see cref="SuitDto" />.
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
            const string paramCode = "S";
            const string paramName = "Spades";
            const short paramSortOrder = 1;

            // ACT
            SuitDto dto = new SuitDto(
                id: paramId,
                paramCode,
                paramName,
                sortOrder: paramSortOrder);

            // ASSERT
            Assert.AreEqual(paramId, dto.Id);
            Assert.AreEqual(paramCode, dto.Code);
            Assert.AreEqual(paramName, dto.Name);
            Assert.AreEqual(paramSortOrder, dto.SortOrder);
        }
    }
}