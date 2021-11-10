using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculatorLibrary;

namespace CalculatorLibrary.UnitTesting
{
    [TestClass]
    public class CalculatorUnitTest
    {
        [TestMethod]
        public void Sum_WithValidInput_ProvideValidAddition()
        {
            // AAA 

            int a = 20;
            int b = 20;
            int expected = 40;

            Calculator calculator1 = new Calculator();

            int actual = calculator1.Sum(a, b);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Subtract_WithValidInput_ProvideValidResult()
        {
            // AAA 

            int a = 20;
            int b = 10;
            int expected = 10;
            Calculator calculator = new Calculator();

            int actual = calculator.Subtract(a, b);
            Assert.AreEqual(expected, actual);

        }
        
        [TestMethod]
        public void Multiply_WithValidInput_ProvideValidResult()
        {
            // AAA 

            int a = 10;
            int b = 10;
            int expected = 100;
            Calculator calculator = new Calculator();

            int actual = calculator.Multiply(a, b);
            Assert.AreEqual(expected, actual);

        }
    }
}
