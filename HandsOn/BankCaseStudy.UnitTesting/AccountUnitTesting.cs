using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using BankCaseStudyApp;

namespace BankCaseStudy.UnitTesting
{
    [TestClass]
    public class AccountUnitTesting
    {
        [TestMethod]
        public void SetName_WithValidName_SetName()
        {
            SavingsAccount target = new SavingsAccount();
            target.Active = true;
            target.SetName("Rakesh");
            Assert.AreEqual("Rakesh", target.Name);
        }
        
        [TestMethod]
        public void Gender_WithValidGender_SaveGender()
        {
            SavingsAccount target = new SavingsAccount();
            target.Active = true;
            target.SetGender("Male");
            Assert.AreEqual("Male", target.Gender);
        }
        
        [TestMethod]
        public void PhoneNumber_WithNumber_SavePhoneNumber()
        {
            SavingsAccount target = new SavingsAccount();
            target.Active = true;
            target.SetPhoneNumber("1234");

            Assert.AreEqual("1234", target.PhoneNumber);
        }
        
        [TestMethod]
        public void DepositAmount_WithActive_SaveBalance()
        {
            SavingsAccount target = new SavingsAccount();
            target.Active = true;

            target.Deposit(1000);

            Assert.AreEqual(1000, target.Balance);
        }

        [TestMethod]
        [ExpectedException(typeof(AccountAlreadyClosedException))]
        public void DepositAmount_WithInactive_ThrowException()
        {
            SavingsAccount target = new SavingsAccount();
            target.Active = false;

            target.Deposit(1000);
        }


        [TestMethod]
        public void CloseAccount_WithAlreadyActive_SetInactive()
        {
            SavingsAccount target = new SavingsAccount();
            target.Active = true;
            target.Close();
            Assert.AreEqual(false, target.Active);
        }

        [TestMethod]
        [ExpectedException(typeof(AccountAlreadyClosedException))]
        public void CloseAccount_WithAlreadyClosed_ThrowException()
        {
            SavingsAccount target = new SavingsAccount();
            target.Active = false;
            target.Close();
        }

        [TestMethod]
        public void WithdrawAmount_WithActive_DebitBalance()
        {
            SavingsAccount target = new SavingsAccount();
            target.Active = true;
            target.Pin = 1234;
            target.Deposit(1000);
            target.Withdraw(200, 1234);

            Assert.AreEqual(800, target.Balance);
        }
        
        [TestMethod]
        [ExpectedException(typeof(AccountAlreadyClosedException))]
        public void WithdrawAmount_WithInActive_ThrowException()
        {
            SavingsAccount target = new SavingsAccount();
            target.Active = false;
            target.Pin = 1234;
            target.Balance = 1000;
            target.Withdraw(200, 1234);

        }
        
        [TestMethod]
        [ExpectedException(typeof(InvalidPinException))]
        public void WithdrawAmount_WithActiveAndInvalidPin_ThrowException()
        {
            SavingsAccount target = new SavingsAccount();
            target.Active = true;
            target.Pin = 1234;
            target.Balance = 1000;
            target.Withdraw(200, 134);
        }
        
        
        [TestMethod]
        [ExpectedException(typeof(InsufficientBalanceException))]
        public void WithdrawAmount_WithActiveAndAmountExceed_ThrowException()
        {
            SavingsAccount target = new SavingsAccount();
            target.Active = true;
            target.Pin = 1234;
            target.Balance = 1000;
            target.Withdraw(2000, 1234);
        }


    }


    [TestClass]
    public class SavingsAccountClassUnitTesting
    {
        [TestMethod]
        public void OpenAccount_WithValidAge_ShouldActivate()
        {
            SavingsAccount target = new SavingsAccount();
            target.DOB = Convert.ToDateTime("26/06/1999");
            target.Open();
            bool actual = target.Active;
            Assert.AreEqual(true, actual);
        }
         [TestMethod]
        public void OpenAccount_WithAge18_ShouldActivate()
        {
            SavingsAccount target = new SavingsAccount();
            target.DOB = Convert.ToDateTime("20/11/2003");
            target.Open();
            bool actual = target.Active;
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(AgeInvalidException))]
        public void OpenAccount_WithInValidAge_ShouldThrowException()
        {
            SavingsAccount target = new SavingsAccount();
            target.DOB = Convert.ToDateTime("26/06/2009");
            target.Open();
        }
    }


    [TestClass]
    public class CurrentAccountClassUnitTesting
    {
        [TestMethod]
        public void OpenCurrent_WithValidRegiNo_ShouldSetActiveTrue()
        {
            CurrentAccount target = new CurrentAccount();
            target.RegistrationNo = "4545";

            target.Open();
            bool actual = target.Active;
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        
        public void OpenCurrent_WithNullRegiNo_ShouldSetActiveFalse()
        {
            CurrentAccount target = new CurrentAccount();
            target.RegistrationNo = null;
            target.Open();
            bool actual = target.Active;
            Assert.AreEqual(false, actual);
        }
    }
}
