// <copyright file="ConstructorTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Data.Dtos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Data.Tests.Dtos.OwnerDtoTests
{
    /// <summary>
    /// Test constructor for <see cref="OwnerDto" />.
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
            const string paramCode = "CBC";
            const string paramName = "County Bridge Club";
            const bool paramIsClub = true;

            // ACT
            OwnerDto dto = new OwnerDto(
                id: paramId,
                code: paramCode,
                name: paramName,
                isClub: paramIsClub);

            // ASSERT
            Assert.AreEqual(paramId, dto.Id);
            Assert.AreEqual(paramCode, dto.Code);
            Assert.AreEqual(paramName, dto.Name);
            Assert.AreEqual(paramIsClub, dto.IsClub);
        }
    }
}