using System;

namespace BankCaseStudyApp
{
    public class CurrentAccount : Account
    {
        public string CompanyName { get; set; }
        public string Website { get; set; }
        public string RegistrationNo { get; set; }

        public override bool Open()
        {
            if (ValidateClass.CheckRegistration(this.RegistrationNo))
            {
                string  num = Operation.GenerateAcctNo().ToString();
                this.SetAccNo(num);                
                this.Active = true;
                this.CompanyName = "Sanket Traders";
                this.Website = "sanky.com";
            }
            else
                this.Active = false;  
            return true;
        }
    }
}
