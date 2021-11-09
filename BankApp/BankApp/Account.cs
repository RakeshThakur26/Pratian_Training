using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    interface  IAccount
    {
        long Acc_No { get; set; }
        string Cust_Name { get; set; }
        double Balance { get; set; }
        double Min_Balance { get; set; }
        double Rate_Of_Interest { get; set; }

        long getAccountNumber();
        string getCustomerName();
        void Withdraw(double amount);
        void Deposit(double amount);
        string Open();
        string Close();
        string Stop_Payment();
        double getMinBalance();
        double RateOfInterest();        

    }
}
