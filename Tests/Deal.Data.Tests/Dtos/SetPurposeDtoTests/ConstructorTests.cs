﻿// <copyright file="ConstructorTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Data.Dtos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Data.Tests.Dtos.SetPurposeDtoTests
{
    /// <summary>
    /// Test constructor for <see cref="SetPurposeDto" />.
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
            const string paramCode = "TEACH";
            const string paramName = "Teaching";

            // ACT
            SetPurposeDto dto = new SetPurposeDto(
                id: paramId,
                code: paramCode,
                name: paramName);

            // ASSERT
            Assert.AreEqual(paramId, dto.Id);
            Assert.AreEqual(paramCode, dto.Code);
            Assert.AreEqual(paramName, dto.Name);
        }
    }
}