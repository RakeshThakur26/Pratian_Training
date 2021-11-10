using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorLibrary.UnitTestProject
{
    [TestClass]
    public class CalculatorUnitTest
    {
        [TestMethod]
        public void Sum_WithValidInput_ProvideValidSum()
        {
            // AAA
            // A - Arrange
            int a = 10;
            int b = 20;
            int expected = 30;
            CalculatorClassLibrary.Calculator traget = new CalculatorClassLibrary.Calculator();
            // A - Act
            int actual = traget.Sum(a, b);
            // A - Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Subtract_WithValidInput_ProvidesValidResult()
        {
            CalculatorClassLibrary.Calculator traget = new CalculatorClassLibrary.Calculator();
            int actual = traget.Subtract(10, 10);
            Assert.AreEqual(0, actual);
        }
    }
}
