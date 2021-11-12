using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn2
{
    class Program
    {
        static void Main(string[] args)
        {
            NotifyMeDelegate d = new NotifyMeDelegate(Listener.GetNotified);
            Client.InvokeDelegate(d);

            NotifyMeDelegate d2 = new NotifyMeDelegate(Listener.GetNotifiedAgain);
            Client.InvokeDelegate(d2);


            Console.Read();
        }
    }
}
