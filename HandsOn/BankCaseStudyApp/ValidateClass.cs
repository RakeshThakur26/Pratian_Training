using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCaseStudyApp
{
    public class ValidateClass
    {
        public static bool OpenSaving(DateTime dt)
        {
            bool valid = false;
            
                if ((DateTime.Today.Year - dt.Year) > 18)
                {                    
                            valid = true;
                }
                else if ((DateTime.Today.Year - dt.Year) == 18)
                {
                    if ((dt.Month <= DateTime.Today.Month))
                        if (dt.Day <= DateTime.Today.Day)
                            valid = true;
                }
                if(!valid)
                {
                    throw new AgeInvalidException("Age is below 18");
                }
            
            
            return valid;
        }

        public static bool CheckRegistration(string reg)
        {
            if (string.IsNullOrWhiteSpace(reg))
                return false;
            return true;
        }
    }
}
