using System;

namespace BankCaseStudyApp
{
    public class SavingsAccount : Account
    {
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }

        public override bool Open()
        {
            if (ValidateClass.OpenSaving(this.DOB))
            {                
                this.Active = true;
                this.DtActive = DateTime.Today;
                this.DtOpen = DateTime.Today;
                this.Privilage = Privilage.GOLD;
            }
           
            return true;
        }

        public void SetPhoneNumber(string num)
        {
            this.PhoneNumber = num;
        }

        public void SetGender(string gen)
        {
            this.Gender = gen;
        }
    }
}
