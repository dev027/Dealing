// <copyright file="ConstructorTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Domain.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deal.Domain.Tests.Exceptions.SetFactoryExceptions.SetFactoryExceptionTests
{
    /// <summary>
    /// Test the constructors for <see cref="SetFactoryExceptions" />.
    /// </summary>
    [TestClass]
    public class ConstructorTests
    {
        /// <summary>
        /// Tests the default constructor.
        /// </summary>
        [TestMethod]
        public void Test_Default_Constructor()
        {
            // ACT
            SetFactoryException exception = new SetFactoryException();

            // ASSERT
            Assert.IsNull(exception.InnerException);
            Assert.AreEqual("Exception of type 'Deal.Domain.Exceptions.SetFactoryException' was thrown.", exception.Message);
        }

        /// <summary>
        /// Tests the message constructor.
        /// </summary>
        [TestMethod]
        public void Test_Message_Constructor()
        {
            // ARRANGE
            const string paramMessage = "My error message";

            // ACT
            SetFactoryException exception = new SetFactoryException(
#pragma warning disable CA1303 // Do not pass literals as localized parameters
                message: paramMessage);
#pragma warning restore CA1303 // Do not pass literals as localized parameters

            // ASSERT
            Assert.IsNull(exception.InnerException);
            Assert.AreEqual(paramMessage, exception.Message);
        }

        /// <summary>
        /// Tests the message and exception constructor.
        /// </summary>
        [TestMethod]
        public void Test_Message_And_Exception_Constructor()
        {
            // ARRANGE
            const string paramMessage = "My error message";
            InvalidOperationException paramInnerException = new InvalidOperationException();

            // ACT
            SetFactoryException exception = new SetFactoryException(
#pragma warning disable CA1303 // Do not pass literals as localized parameters
                message: paramMessage,
#pragma warning restore CA1303 // Do not pass literals as localized parameters
                innerException: paramInnerException);

            // ASSERT
            Assert.IsNotNull(exception.InnerException);
            Assert.AreEqual(paramMessage, exception.Message);
        }
    }
}