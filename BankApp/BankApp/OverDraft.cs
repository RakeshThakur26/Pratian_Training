using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class OverDraft : ICommon
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


        public OverDraft(string type)
        {

            if (type.Equals("Corporate"))
            {

                this.Min_Balance = 10000;
                this.Rate_Of_Interest = 2.5;   
            }
            else
            {
                this.Min_Balance = 2000;
                this.Rate_Of_Interest = 4;
            }
        }
    }
}
