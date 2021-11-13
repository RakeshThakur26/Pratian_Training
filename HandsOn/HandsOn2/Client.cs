using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn2
{
    delegate void NotifyMeDelegate(string sInfo);
    class Client
    {
        public static void InvokeDelegate(NotifyMeDelegate d)
        {
            d("You are late paying your bills!");
        }
    }
}
