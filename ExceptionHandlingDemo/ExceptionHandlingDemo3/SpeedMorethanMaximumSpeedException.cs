using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo3
{
    class SpeedMorethanMaximumSpeedException : ApplicationException
    {
        Exception innerException;
        public string errorMssg { get; set; }
        public SpeedMorethanMaximumSpeedException(string msg = null, Exception innerExpception = null) : base(msg, innerExpception)
        {
            errorMssg = msg;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="CurrentSpeed"></param>
        /// <param name="MaximumSpeed"></param>
        /// <exception cref="SpeedMorethanMaximumSpeedException"></exception>
        public static void SpeedMorethanMaximumSpeedExceptionMethod(int CurrentSpeed, int MaximumSpeed)
        {
            if (CurrentSpeed > MaximumSpeed)
                throw new SpeedMorethanMaximumSpeedException("Current Speed Exceeds Max Speed");
        }

    }
}
