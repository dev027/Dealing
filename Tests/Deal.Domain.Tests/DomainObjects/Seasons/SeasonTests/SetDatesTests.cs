// <copyright file="SetDatesTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Domain.DomainObjects.Organisers;
using Deal.Domain.DomainObjects.Seasons;
using Deal.Domain.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Domain.Tests.DomainObjects.Seasons.SeasonTests
{
    /// <summary>
    /// Tests the method <see cref="Season.SetDates"/>.
    /// </summary>
    [TestClass]
    public class SetDatesTests
    {
        /// <summary>
        /// Tests SetDates() with valid dates.
        /// </summary>
        [TestMethod]
        public void Test_SetDates_With_Valid_Dates()
        {
            // ARRANGE
            DateTime paramStartDate = new DateTime(2020, 1, 1);
            DateTime paramEndDate = new DateTime(2020, 12, 31);
            ISeason season = new Season(
                id: Guid.NewGuid(),
                organiser: new Organiser(
                    id: Guid.NewGuid(),
                    code: "CBC",
                    name: "County Bridge Club"),
                description: "Description",
                startDate: new DateTime(2000, 1, 1),
                endDate: new DateTime(2000, 12, 31));

            // ACT
            season.SetDates(paramStartDate, paramEndDate);

            // ASSERT
            Assert.AreEqual(paramStartDate, season.StartDate);
            Assert.AreEqual(paramEndDate, season.EndDate);
        }

        /// <summary>
        /// Tests the SetDates() start date after end date throw exception.
        /// </summary>
        [ExpectedException(typeof(StartDateAfterEndDateException))]
        [TestMethod]
        public void Test_SetDates_Start_Date_After_End_Date_Throws_Exception()
        {
            // ARRANGE
            DateTime paramStartDate = new DateTime(2020, 12, 31);
            DateTime paramEndDate = new DateTime(2020, 1, 1);
            ISeason season = new Season(
                id: Guid.NewGuid(),
                organiser: new Organiser(
                    id: Guid.NewGuid(),
                    code: "CBC",
                    name: "County Bridge Club"),
                description: "Description",
                startDate: new DateTime(2000, 1, 1),
                endDate: new DateTime(2000, 12, 31));

            // ACT
            season.SetDates(paramStartDate, paramEndDate);
        }

        /// <summary>
        /// Tests SetDates() when start date equals end date.
        /// </summary>
        [TestMethod]
        public void Test_SetDates_Start_Date_Equals_End_Date()
        {
            // ARRANGE
            DateTime paramStartDate = DateTime.Today;
            DateTime paramEndDate = DateTime.Today;
            ISeason season = new Season(
                id: Guid.NewGuid(),
                organiser: new Organiser(
                    id: Guid.NewGuid(),
                    code: "CBC",
                    name: "County Bridge Club"),
                description: "Description",
                startDate: new DateTime(2000, 1, 1),
                endDate: new DateTime(2000, 12, 31));

            // ACT
            season.SetDates(paramStartDate, paramEndDate);

            // ASSERT
            Assert.AreEqual(paramStartDate, season.StartDate);
            Assert.AreEqual(paramEndDate, season.EndDate);
        }
    }
}