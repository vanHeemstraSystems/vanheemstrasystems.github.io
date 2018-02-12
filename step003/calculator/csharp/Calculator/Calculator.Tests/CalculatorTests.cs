using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        [TestCategory("Message")]
        public void Message()
        {
            //Arrange
            var calculator = new Calculator();
            //Act
            string message = calculator.Message("Hello World!");
            //Assert
            Assert.AreEqual("Hello World!", message);
        }
    }
}
