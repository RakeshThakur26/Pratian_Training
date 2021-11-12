using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn2
{
    class Listener
    {
        public static void GetNotified(string sInfo)
        {
            Console.WriteLine("I got notified with the following information: {0}", sInfo);
        }
        public static void GetNotifiedAgain(string sInfo)
        {
            Console.WriteLine("I got notified with the following information: {0}", sInfo + " due date is very close");
        }
        
    }
}
