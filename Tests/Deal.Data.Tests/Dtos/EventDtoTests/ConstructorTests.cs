// <copyright file="ConstructorTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Data.Dtos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Data.Tests.Dtos.EventDtoTests
{
    /// <summary>
    /// Test constructor for <see cref="EventDto" />.
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
            Guid paramSeasonId = Guid.NewGuid();
            const string paramName = "Event Name";
            const string paramSubName = "EVent Subname";
            const int paramHandCopies = 50;
            const bool paramIsDoubleSidedHandCopies = true;

            // ACT
            EventDto dto = new EventDto(
                id: paramId,
                seasonId: paramSeasonId,
                name: paramName,
                subName: paramSubName,
                handCopies: paramHandCopies,
                isDoubleSidedHandCopies: paramIsDoubleSidedHandCopies);

            // ASSERT
            Assert.AreEqual(paramId, dto.Id);
            Assert.AreEqual(paramSeasonId, dto.SeasonId);
            Assert.AreEqual(paramName, dto.Name);
            Assert.AreEqual(paramSubName, dto.SubName);
            Assert.AreEqual(paramHandCopies, dto.HandCopies);
            Assert.AreEqual(paramIsDoubleSidedHandCopies, dto.IsDoubleSidedHandCopies);
        }
    }
}