// <copyright file="ConstructorTests.cs" company="Do It Wright">
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
    /// Test the constructor for <see cref="Season"/>.
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
            Guid paramGuid = Guid.NewGuid();
            IOrganiser paramOrganiser = new Organiser(
                id: Guid.NewGuid(),
                code: "CBC",
                name: "County Bridge Club");
            const string paramDescription = "2020";
            DateTime paramStartDate = new DateTime(2020, 1, 1);
            DateTime paramEndDate = new DateTime(2020, 12, 31);

            // ACT
            ISeason season = new Season(
                id: paramGuid,
                organiser: paramOrganiser,
                description: paramDescription,
                startDate: paramStartDate,
                endDate: paramEndDate);

            // ASSERT
            Assert.AreEqual(paramGuid, season.Id);
            Assert.AreSame(paramOrganiser, season.Organiser);
            Assert.AreEqual(paramDescription, season.Description);
            Assert.AreEqual(paramStartDate, season.StartDate);
            Assert.AreEqual(paramEndDate, season.EndDate);
        }

        /// <summary>
        /// Tests the constructor null Organiser throws exception.
        /// </summary>
        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void Test_Constructor_Null_Organiser_Throws_Exception()
        {
            // ARRANGE
            Guid paramGuid = Guid.NewGuid();
            const string paramDescription = "2020";
            DateTime paramStartDate = new DateTime(2020, 1, 1);
            DateTime paramEndDate = new DateTime(2020, 12, 31);

            // ACT
            _ = new Season(
                id: paramGuid,
                organiser: null,
                description: paramDescription,
                startDate: paramStartDate,
                endDate: paramEndDate);

            // ASSERT
            Assert.Fail();
        }

        /// <summary>
        /// Tests the constructor null description code throws exception.
        /// </summary>
        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void Test_Constructor_Null_Description_Throws_Exception()
        {
            // ARRANGE
            Guid paramGuid = Guid.NewGuid();
            IOrganiser paramOrganiser = new Organiser(
                id: Guid.NewGuid(),
                code: "CBC",
                name: "County Bridge Club");
            DateTime paramStartDate = new DateTime(2020, 1, 1);
            DateTime paramEndDate = new DateTime(2020, 12, 31);

            // ACT
            _ = new Season(
                id: paramGuid,
                organiser: paramOrganiser,
                description: null,
                startDate: paramStartDate,
                endDate: paramEndDate);

            // ASSERT
            Assert.Fail();
        }

        /// <summary>
        /// Tests the constructor start date after end date throws exception.
        /// </summary>
        [ExpectedException(typeof(StartDateAfterEndDateException))]
        [TestMethod]
        public void Test_Constructor_Start_Date_After_End_Date_Throws_Exception()
        {
            // ARRANGE
            Guid paramGuid = Guid.NewGuid();
            IOrganiser paramOrganiser = new Organiser(
                id: Guid.NewGuid(),
                code: "CBC",
                name: "County Bridge Club");
            const string paramDescription = "2020";
            DateTime paramStartDate = new DateTime(2020, 12, 31);
            DateTime paramEndDate = new DateTime(2020, 1, 1);

            // ACT
            _ = new Season(
                id: paramGuid,
                organiser: paramOrganiser,
                description: paramDescription,
                startDate: paramStartDate,
                endDate: paramEndDate);

            // ASSERT
            Assert.Fail();
        }

        /// <summary>
        /// Tests the constructor when start date equals end date.
        /// </summary>
        [TestMethod]
        public void Test_Constructor_Start_Date_Equals_End_Date()
        {
            // ARRANGE
            Guid paramGuid = Guid.NewGuid();
            IOrganiser paramOrganiser = new Organiser(
                id: Guid.NewGuid(),
                code: "CBC",
                name: "County Bridge Club");
            const string paramDescription = "2020";
            DateTime paramStartDate = DateTime.Today;
            DateTime paramEndDate = DateTime.Today;

            // ACT
            ISeason organiser = new Season(
                id: paramGuid,
                organiser: paramOrganiser,
                description: paramDescription,
                startDate: paramStartDate,
                endDate: paramEndDate);

            // ASSERT
            Assert.AreEqual(paramGuid, organiser.Id);
            Assert.AreSame(paramOrganiser, organiser.Organiser);
            Assert.AreEqual(paramStartDate, organiser.StartDate);
            Assert.AreEqual(paramEndDate, organiser.EndDate);
        }
    }
}