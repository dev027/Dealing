// <copyright file="ConstructorTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Data.Dtos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Data.Tests.Dtos.SeasonDtoTests
{
    /// <summary>
    /// Test constructor for <see cref="SeasonDto" />.
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
            Guid paramOrganiserId = Guid.NewGuid();
            const string paramDescription = "Description";
            DateTime paramStartDate = new DateTime(2020, 1, 1);
            DateTime paramEndDate = new DateTime(2020, 12, 31);

            // ACT
            SeasonDto dto = new SeasonDto(
                id: paramId,
                organiserId: paramOrganiserId,
                description: paramDescription,
                startDate: paramStartDate,
                endDate: paramEndDate);

            // ASSERT
            Assert.AreEqual(paramId, dto.Id);
            Assert.AreEqual(paramOrganiserId, dto.OrganiserId);
            Assert.AreEqual(paramDescription, dto.Description);
            Assert.AreEqual(paramStartDate, dto.StartDate);
            Assert.AreEqual(paramEndDate, dto.EndDate);
        }
    }
}