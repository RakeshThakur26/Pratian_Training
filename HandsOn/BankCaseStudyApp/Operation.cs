using System;
using System.Threading;

namespace BankCaseStudyApp
{
    public class Operation
    {
        static int accno = 1000;
        public static int GenerateAcctNo()
        {
            accno++;
            return accno;
            
        }
    }
}
