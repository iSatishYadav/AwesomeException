using Microsoft.VisualStudio.TestTools.UnitTesting;
using AwesomeException;
using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeException.Tests
{
    [TestClass()]
    public class ExceptionExtensionsTests
    {
        [TestMethod()]
        public void GetExceptionStack_Should_Return_All_Exceptions_When_Multiple_Inner_Exceptions_Are_Present()
        {
            //Arrange
            var exception = new Exception("This is #1", new Exception("This is #2", new Exception("This is #3", new Exception("This is #4"))));

            //Act
            var exceptionStack = exception.GetExceptionStack();

            //Assert
            Assert.IsTrue(exceptionStack.Count == 4);

        }

        [TestMethod()]
        public void GetExceptionStack_Should_Return_Single_Exception_When_No_Inner_Exceptions_Are_Present()
        {
            //Arrange
            var exception = new Exception("This is #1");

            //Act
            var exceptionStack = exception.GetExceptionStack();

            //Assert
            Assert.IsTrue(exceptionStack.Count == 1);

        }
    }
}