using System;

namespace BankCaseStudyApp
{
    public class DayLimitExceedsException : Exception
    {
        public DayLimitExceedsException(string msg) : base(msg)
        {

        }
    }
}
