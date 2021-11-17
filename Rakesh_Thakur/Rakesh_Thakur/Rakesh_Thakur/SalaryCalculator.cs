using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rakesh_Thakur
{
    class SalaryCalculator
    {

        public static float calculateAllowance(int experiance, float basic)
        {
            if (experiance <= 2)
                return ((float)(basic * 0.3));
            else if(experiance <= 4)
                return ((float)(basic * 0.4));
            else if(experiance <= 6)
                return ((float)(basic * 0.5));
            else 
                return ((float)(basic * 0.65));
        }
    }
}
