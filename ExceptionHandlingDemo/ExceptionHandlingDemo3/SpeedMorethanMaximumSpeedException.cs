using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo3
{
    class SpeedMorethanMaximumSpeedException : ApplicationException
    {
        public string errorMssg { get; set; }
        public SpeedMorethanMaximumSpeedException(string msg = null, Exception innerExp = null) : base(msg, innerExp)
        {

        }
    }
}
