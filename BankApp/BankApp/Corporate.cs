using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    interface ICorporate : IAccount
    {
        string Company_Type { get; set; }
        string Authorized_Signatory { get; set; }
        string Date_of_Incorp { get; set; }
        string Nature_of_Business { get; set; }
    }
}
