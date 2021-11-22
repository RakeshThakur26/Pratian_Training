using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankCaseStudyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //List<Account> accounts = new List<Account>();
                SavingsAccount person1 = new SavingsAccount();
               // person1.SetName("Rakesh");
                string num = Operation.GenerateAcctNo().ToString();
                person1.SetAccNo(num);
                person1.SetGender("Male");
                person1.SetPhoneNumber("1234");
                person1.DOB = Convert.ToDateTime("11/11/2003");
                person1.Open();

                Console.WriteLine("Account number : "+person1.AccNo);

                //person1.Close();
                //person1.Close();
                person1.Deposit(1000);
                person1.Pin = 1234;
                Console.WriteLine("Current balance = " + person1.Balance);

                Console.WriteLine("********************************");

                
                // person1.Withdraw(200, 1234);
                //Console.WriteLine("Current balance = " + person1.Balance);
                SavingsAccount person2 = new SavingsAccount();
                person2.Name = "abc";
                num = Operation.GenerateAcctNo().ToString();
                person2.SetAccNo(num);
                person2.Active = true;
                Console.WriteLine("Account number : " + person2.AccNo);
                // //Thread.Sleep(200);
                Console.WriteLine("Balance = " + person2.Balance);
                TransferFunds t = new TransferFunds();
                t.TransferAmount(person1, person2, 200, 1234);

                Console.WriteLine(person1.Balance + "\t" + person2.Balance);
                // CurrentAccount person3 = new CurrentAccount();
                // person3.Name = "pqr";
                // person3.CompanyName = "abc";
                // person3.RegistrationNo = "123";
                // person3.Open();




                //Thread.Sleep(200);

                //CurrentAccount person4 = new CurrentAccount();
                //person4.Name = "ere";
                //num = Operation.GenerateAcctNo().ToString();
                //person4.SetAccNo(num);
                //Console.WriteLine(person4.AccNo);


            }
            catch (AccountAlreadyClosedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidPinException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (AgeInvalidException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
