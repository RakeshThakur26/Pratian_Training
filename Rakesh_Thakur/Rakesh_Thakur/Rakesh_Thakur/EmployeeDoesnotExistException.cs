using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rakesh_Thakur
{
    class EmployeeDoesnotExistException : Exception
    {
        public EmployeeDoesnotExistException(string msg) : base(msg)
        {

        }
    }
}
