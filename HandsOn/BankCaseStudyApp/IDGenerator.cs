using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCaseStudyApp
{
    public static class IDGenerator
    {
        static public int GenerateID()
        {
            StreamReader sr = null;
            StreamWriter sw = null;
            int num;
            try
            {
                sr = new StreamReader(@"..\..\numbers.txt");
                num = Convert.ToInt32(sr.ReadLine());
                sr.Close();
                
                sw = new StreamWriter(@"..\..\numbers.txt");
                sw.WriteLine(++num);

                
            }
            finally
            {
                sw.Close();
            }
            return num;
         }
    }
}
