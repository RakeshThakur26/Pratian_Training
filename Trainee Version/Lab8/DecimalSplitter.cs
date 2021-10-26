using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab8
{
    class DecimalSplitter
    {
        public static int GetWhole(double Number)
        {
            return ((int)Number);
        }
        
        public static double GetFraction(double Number)
        {
            return (Number - (int)Number);
        }    
    }
}
