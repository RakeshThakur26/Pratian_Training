using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentResultCalculatorClassLibrary;
using System;
using Moq;

namespace StudentResultCalculatorLibraryClass.UnitTestProject
{
    //public class DummyNotification : INotification
    //{
    //    public void Notify(string message, string address)
    //    {
            
    //    }
    //}



    [TestClass]
    public class ResultCalculatorUnitTest
    {
        StudentResultCalculator target = null;
        Mock<INotification> mock = null;

        [TestInitialize]
        public void Init()
        {
            mock = new Mock<INotification>();
            mock.Setup(o => o.Notify(string.Empty, string.Empty));
            
            target = new StudentResultCalculator(mock.Object);
        }

        [TestCleanup]
        public void UnInit()
        {
            target = null;
        }


        [TestMethod]
        public void CalculateResult_WithAvg35_ShouldReturnPass()
        {
            string result = target.StudentCalculator(40, 40, 40);
            Assert.AreEqual("Pass", result);
        }
        [TestMethod]
        public void CalculateResult_WithAvgLess35_ShouldReturnFail()
        {
            string result = target.StudentCalculator(34, 35, 20);
            Assert.AreEqual("Fail", result);
        }
        [TestMethod]
        public void CalculateResult_WithAvgGreater65_ShouldReturnFirst()
        {
            string result = target.StudentCalculator(70, 65, 80);
            Assert.AreEqual("First class", result);
        }
        [TestMethod]
        public void CalculateResult_WithAvgGreater59_ShouldReturnSecond()
        {
            string result = target.StudentCalculator(59, 59, 62);
            Assert.AreEqual("Second class", result);
        }


        [TestMethod]
        //[ExpectedException(typeof(InvalidMarksException))]
        public void CalculateResult_WithMarksAbove100Below0_ShouldThrowCustomException()
        {
            Assert.ThrowsException<InvalidMarksException>(() => target.StudentCalculator(120, 50, 50));

        }

        [TestMethod]
        public void CalculateResult_WithValidMarks_ShouldCallNotifyMethod()
        {
            string actual = target.StudentCalculator(50,40,70);
           // mock.Verify(obj => obj.Notify("Your result is Fail", "StudentEmailId@mail.com"), Times.Once);
            mock.Verify(obj => obj.Notify("Your result is Pass", "StudentEmailId@mail.com"), Times.Once); 
        }

        [TestMethod]
        public void CalculateResult_WithValidMarks_ShouldCallNotifyFail()
        {
            string actual = target.StudentCalculator(20, 30, 20);
            mock.Verify(obj => obj.Notify("Your result is Fail", "StudentEmailId@mail.com"), Times.Once);
        }
    }
}
