using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    interface IPersonal : IAccount
    {
        string Nominee { get; set; }
        string Introducer_Name { get; set; }
        string Occupation { get; set; }


    }
}
