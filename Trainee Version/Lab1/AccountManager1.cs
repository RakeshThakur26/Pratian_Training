using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1
{
    class AccountManager1
    {
     
        public void FillAccountData(Account Acc)
        {
            Acc.AccNo = "004701";       // Assigning Account number to Set property of Account class
            Acc.Name = "Nitesh";        // Assigning Account holder name to Set property of Account class
            Acc.Balance = 45000.0;      // Assigning Balance to Set property of Account class
        }

     
        public void DisplayAccountData(Account Acc) 
        {
		    Console.WriteLine("AccNo : " + Acc.AccNo);  // Calling get property of Account class to Display Account number
            Console.WriteLine("Name : " + Acc.Name);    // Calling get property of Account class to Display Account holder name
            Console.WriteLine("Balance : " + Acc.Balance); // Calling get property of Account class to Display Balance
	    }
    }
}
