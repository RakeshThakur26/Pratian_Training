using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace MultiThreadingDemo1
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch start = Stopwatch.StartNew();
            Console.WriteLine("Main Thread : " + Thread.CurrentThread.ManagedThreadId);
            //Method1();
            //Method2();           

            Thread t1 = new Thread(Method1);
            t1.Start();

            Thread t2 = new Thread(Method2);
            t2.Start();

            Thread t3 = new Thread(Method3);
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();
            Console.WriteLine("End of Main");

            Console.WriteLine(start.ElapsedMilliseconds);

            Console.Read();

        }

        static void Method1()
        {
            Console.WriteLine("Method 1 : " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(3000);
        }

        static void Method2()
        {
            Console.WriteLine("Method 2 : " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(3000);
        }

        static void Method3()
        {
            int a = Sum(3, 4);
            Console.WriteLine(a);
            Thread.Sleep(3000);
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

    }
}
