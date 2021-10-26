using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class AccountManager
    {
     
        public void FillAccountData(Account Acc)
        {
            // Taking inputs from user to Store account details
           
            // Taking Account number from console
            Console.WriteLine("Enter account number : ");
            Acc.AccNo = CustomConsole.ReadString();

            // Taking Account holder name from console
            Console.WriteLine("Enter account holder name : ");
            Acc.Name = CustomConsole.ReadString();
             
            // Taking balance from console
            Console.WriteLine("Enter balance : ");
            Acc.Balance = CustomConsole.ReadDouble();
        }

      
        public void DisplayAccountData(Account Acc)
        {
            Console.WriteLine();
            Console.WriteLine("AccNo : " + Acc.AccNo);
            Console.WriteLine("Name : " + Acc.Name);
            Console.WriteLine("Balance : " + Acc.Balance);
        }
    }
}
