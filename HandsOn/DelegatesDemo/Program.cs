using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    delegate void MyDelegate(string method);

    class Program
    {
        
        static void Main(string[] args)
        {
            MyDelegate del = new MyDelegate(Greetings);
            Program p = new Program();
            del += p.Hello;           
            del -= Greetings;

            del("Rakesh");

            Console.Read();
        }
        public static void Greetings(string name)
        {
            Console.WriteLine("Greetings :  " + name);
        } 
        
        public void Hello(string name)
        {
            Console.WriteLine("Hello :  " + name);
        }
    }
}
