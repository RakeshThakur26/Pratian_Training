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

            Console.WriteLine(a.Balance);
            a.Withdraw(10);
            Console.WriteLine(a.Balance);

            Console.Read();
        }
    }

    public delegate void  AlertDelegate();

    class Account
    {
        Alert al = new Alert();
        
        public int Acc_No { get; set; }

        public int Balance { get; private set; }
        public event AlertDelegate alert = null;

        public void Deposit(int amount)
        {
            this.Balance += amount;
            Alert a = new Alert();
            a.SendMail();
        }
        
        public void Withdraw(int amount)
        {
            this.Balance -= amount;
            Alert a = new Alert();
            a.SendSMS();
        }
    }

    class Alert
    {
        public void SendMail()
        {
            Console.WriteLine("Mail sent");
        }

        public void SendSMS()
        {
            Console.WriteLine("SMS sent");
        }

    }
}
