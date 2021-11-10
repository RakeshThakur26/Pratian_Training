using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResultCalculatorLibrary
{
    public class InvalidMarksException : ApplicationException
    {
       
        public InvalidMarksException(string msg=null, Exception innerExp=null):base(msg,innerExp)
        {

        }
    }
}
