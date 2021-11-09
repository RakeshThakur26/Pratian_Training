using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class Savings : ICommon
    {
        private string nominee;
        string IPersonal.Nominee
        {
            get { return nominee; }
            set { nominee = value; }
        }

        private string intoducer_name;
        public string Introducer_Name { get => intoducer_name; set => intoducer_name = value; }

        private string occupation;
        public string Occupation { get => occupation; set => occupation = value; }

        private string company_type;
        public string Company_Type { get => company_type; set => company_type = value; }

        private string autho;
        public string Authorized_Signatory { get => autho; set => autho = value; }

        private string date_Incorp;
        public string Date_of_Incorp { get => date_Incorp; set => date_Incorp = value; }

        private string nature_business;
        public string Nature_of_Business { get => nature_business; set => nature_business = value; }

        private long acc_no;
        public long Acc_No { get => acc_no; set => acc_no = value; }

        private string cust_name;
        public string Cust_Name { get => cust_name; set => cust_name = value; }

        private double balance;
        public double Balance { get => balance; set => balance = value; }

        private double min_balance;
        public double Min_Balance { get => min_balance; set => min_balance = value; }

        private double rate;
        public double Rate_Of_Interest { get => rate; set => rate = value; }

        public Savings(string type)
        {
            if (type.Equals("Corporate"))
            {               
                    this.Min_Balance = 0;
                    this.Rate_Of_Interest = 4.5;
            }
            else
            {
                 this.Min_Balance = 2000;
                 this.Rate_Of_Interest = 5;               
            }
        }

        public long getAccountNumber()
        {
            return this.Acc_No;
        }

        public string getCustomerName()
        {
           return this.Cust_Name;
        }

        public double Withdraw(double amount)
        {
            this.Balance = this.Balance - amount;
            return this.Balance;
        }

        public double Deposit(double amount)
        {
            this.Balance = this.Balance + amount;
            return this.Balance;
        }

        public string Open()
        {
            return "Account is active";
        }

        public string Close()
        {
            return "Account is closed";
        }

        public string Stop_Payment()
        {
            return "Payment is stopped";
        }

        public double getMinBalance()
        {
           return this.Min_Balance;
        }

        public double RateOfInterest()
        {
            return this.Rate_Of_Interest;
        }
    }
}
