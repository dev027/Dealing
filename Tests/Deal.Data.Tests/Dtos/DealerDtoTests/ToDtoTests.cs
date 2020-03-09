// <copyright file="ToDtoTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Data.Dtos;
using Deal.Domain.DomainObjects.Dealers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Data.Tests.Dtos.DealerDtoTests
{
    /// <summary>
    /// Test <see cref="DealerDto.ToDto"/>.
    /// </summary>
    [TestClass]
    public class ToDtoTests
    {
        /// <summary>
        /// Tests method with valid values.
        /// </summary>
        [TestMethod]
        public void Test_Passing_Valid_Values()
        {
            // ARRANGE
            IDealer dealer = new Dealer(
                id: Guid.NewGuid(),
                name: "Steve");

            // ACT
            DealerDto dealerDto = DealerDto.ToDto(dealer);

            // ASSERT
            Assert.AreEqual(dealer.Id, dealerDto.Id);
            Assert.AreEqual(dealer.Name, dealerDto.Name);
        }

        /// <summary>
        /// Tests passing null card throws exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Passing_Null_Card_Throws_Exception()
        {
            // ACT
            _ = DealerDto.ToDto(null);
        }
    }
}