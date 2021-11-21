using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCaseStudyApp
{
    public class AgeInvalidException : Exception
    {
        public AgeInvalidException(string msg) : base(msg)
        {

        }
    }
}
