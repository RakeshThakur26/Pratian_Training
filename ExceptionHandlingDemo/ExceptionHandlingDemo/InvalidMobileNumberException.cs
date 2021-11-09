using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    class InvalidMobileNumberException : ApplicationException
    {
        public InvalidMobileNumberException(string msg) : base(msg)
        {

        }
    }
}
