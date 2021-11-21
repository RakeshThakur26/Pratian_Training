using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCaseStudyApp
{
    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string msg=null, Exception inner=null) : base(msg, inner)
        {

        }
    }
}
