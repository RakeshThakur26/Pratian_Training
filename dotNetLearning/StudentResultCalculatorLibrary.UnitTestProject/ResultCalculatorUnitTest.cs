using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using StudentResultCalculatorLibrary;
using Moq;

namespace StudentResultCalculatorLibrary.UnitTestProject
{

    //class DummyNotification : INotification
    //{
    //    public void Notify(string message, string toaddress)
    //    {
            
    //    }
    //}



    [TestClass]
    
    public class ResultCalculatorUnitTest
    {

        ResultCalculator target = null;
        Mock<INotification> mock = null;

        [TestInitialize]
        public void Init()
        {
            mock = new Mock<INotification>();
            mock.Setup(m => m.Notify(string.Empty, string.Empty));

            target = new ResultCalculator(mock.Object);
        }

        [TestCleanup]
        public void UnInit()
        {
            target = null;
        }

        [TestMethod]
        public void CalculateResult_WithAvg40_ShouldReturnPass()
        {
            //ResultCalculator target = new ResultCalculator(new DummyNotification());
            string actual = target.CalculateResult(40, 40, 40);
            Assert.AreEqual("Pass", actual);

        }

        [TestMethod]
        public void CalculateResult_WithAvg66_ShouldReturnFirstClass()
        {
            string actual = target.CalculateResult(66, 66, 66);
            Assert.AreEqual("First Class", actual);

        }


        [TestMethod]
        public void CalculateResult_WithAvg60_ShouldReturnSecondClass()
        {
            string actual = target.CalculateResult(60, 60, 60);
            Assert.AreEqual("Second Class", actual);

        }

        [TestMethod]
        public void CalculateResult_WithAvg30_ShouldReturnFail()
        {
            string actual = target.CalculateResult(30, 30, 30);
            Assert.AreEqual("Fail", actual);

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidMarksException))]
        public void CalculateResult_WithNegativeMarks_ShouldThrowExp()
        {
            string actual = target.CalculateResult(-30, 30, 30);
            

        }
        [TestMethod]
        public void CalculateResult_WithValidMarks_ShouldCallNotifyMethod()
        {
            string actual = target.CalculateResult(60, 60, 60);
            mock.Verify(m => m.Notify("Your result is Second Class", "student1@mail.com"),Times.Once());
            //Mock.VerifyAll();
        }
    }   
}
