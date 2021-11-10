using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentResultCalculatorClassLibrary;
using System;


namespace StudentResultCalculatorLibraryClass.UnitTestProject
{
    [TestClass]
    public class ResultCalculatorUnitTest
    {
        [TestMethod]
        public void CalculateResult_WithAvg40_ShouldReturnPass()
        {
            string result = StudentResultCalculator.StudentCalculator(40, 40, 40);
            Assert.AreEqual("Pass", result);
        }
        [TestMethod]
        public void CalculateResult_WithAvgLess35_ShouldReturnFail()
        {
            string result = StudentResultCalculator.StudentCalculator(34, 35, 20);
            Assert.AreEqual("Fail", result);
        }
        [TestMethod]
        public void CalculateResult_WithAvgGreater60_ShouldReturnFirst()
        {
            string result = StudentResultCalculator.StudentCalculator(70, 60, 80);
            Assert.AreEqual("First", result);
        }
        [TestMethod]
        public void CalculateResult_WithAvgGreater35Less60_ShouldReturnSecond()
        {
            string result = StudentResultCalculator.StudentCalculator(59, 59, 62);
            Assert.AreEqual("Second", result);
        }


        [TestMethod]
        public void CalculateResult_WithMarksAbove100Below0_ShouldThrowCustomException()
        {
            Assert.ThrowsException<InvalidMarksException>(() => StudentResultCalculator.StudentCalculator(120, 50, 50));

        }
    }
}
