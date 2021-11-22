using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCaseStudyApp
{
    public delegate void NotifyDelegate(string str);
    public abstract class Account 
    {

        public string Name { get; set; }
        public int Pin { get; set; }
        public string AccNo { get; set; }
        public bool Active { get; set; } = false;
        public DateTime DtOpen { get; set; }
        public DateTime DtActive { get; set; }
        public DateTime DtClose { get; set; }
        public double Balance { get; set; }
        public Privilage Privilage { get; set; }

        //public Dictionary<DateTime, double> dayLimit { get; set; } = new Dictionary<DateTime, double>();

        public event NotifyDelegate notify = null;


        public void SetName(string name)
        {
            this.Name = name;
        }

        public bool Close()
        {
            if (!this.Active)
                throw new AccountAlreadyClosedException("Acoount is already closed");

            this.Active = false;
            this.DtClose = DateTime.Now.Date;
            return true;
        }


        public bool Deposit(double amt)
        {
            if (!this.Active)
                throw new AccountAlreadyClosedException("Acoount is already closed");

            this.Balance += amt;
            this.notify = new NotifyDelegate(Notification.Notify);
            this.notify($"{amt} is deposited to {this.AccNo}");

            return true;
        }

        public bool Withdraw(double amt, int pin)
        {
            if (!this.Active)
                throw new AccountAlreadyClosedException("Acoount is already closed");
            if (this.Balance < amt)
                throw new InsufficientBalanceException("Insufficient balance");
            if (pin != this.Pin)
                throw new InvalidPinException("Invalid pin..");

            this.Balance -= amt;

            this.notify($"{amt} is withdrawn from {this.AccNo}");
            return true;
        }

        public abstract bool Open();      
        public void SetAccNo(string accNo)
        {
            this.AccNo = accNo;
        }

    }
}