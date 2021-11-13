using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a = new Account();
            
            a.Deposit(100);
            
            Console.WriteLine("Balance = " + a.Balance);
            a.Withdraw(10);
            Console.WriteLine("Balance = " + a.Balance);

            Console.Read();
        }
    }

    public delegate void AlertDelegate(string str);

    class Account
    {
        Alert al = new Alert();
        
        public int Acc_No { get; set; }

        public int Balance { get; private set; }
        public event AlertDelegate alert = null;

        public void Deposit(int amount)
        {
            this.Balance += amount;
            Console.WriteLine("Do you wan to Subscribe for notification? if yes");
            this.alert = new AlertDelegate(al.SendMail);
            this.alert += al.SendSMS;
            
            this.alert(amount + " Deposited in your account");
        }
        
        public void Withdraw(int amount)
        {
            this.Balance -= amount;
            alert(amount + " Withdrawn from your account");
        }
    }

    class Alert
    {
        public void SendMail(string msg)
        {
            Console.WriteLine("Mail : " + msg);
        }

        public void SendSMS(string msg)
        {
            Console.WriteLine("SMS : " + msg);
        }

    }
}
