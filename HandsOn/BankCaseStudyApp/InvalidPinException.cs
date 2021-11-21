using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCaseStudyApp
{
    public class InvalidPinException : Exception
    {
        public InvalidPinException(string msg) : base(msg)
        {

        }
    }
}
