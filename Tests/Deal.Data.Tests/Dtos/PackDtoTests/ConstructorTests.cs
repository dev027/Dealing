// <copyright file="ConstructorTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Data.Dtos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Data.Tests.Dtos.PackDtoTests
{
    /// <summary>
    /// Test constructor for <see cref="PackDto" />.
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
            Guid paramPackColourId = Guid.NewGuid();
            Guid paramSetId = Guid.NewGuid();
            DateTime paramEnteredService = DateTime.Today;
            const int paramBoardNumber = 1;

            // ACT
            PackDto dto = new PackDto(
                id: paramId,
                packColourId: paramPackColourId,
                setId: paramSetId,
                enteredService: paramEnteredService,
                boardNumber: paramBoardNumber);

            // ASSERT
            Assert.AreEqual(paramId, dto.Id);
            Assert.AreEqual(paramPackColourId, dto.PackColourId);
            Assert.AreEqual(paramSetId, dto.SetId);
            Assert.AreEqual(paramEnteredService, dto.EnteredService);
            Assert.AreEqual(paramBoardNumber, dto.BoardNumber);
        }
    }
}