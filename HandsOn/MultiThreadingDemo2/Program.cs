using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task1 = new Task(M1);
            task1.Start();

            Task taskt1 = Task.Factory.StartNew(M1);

            Thread t2 = new Thread(() => { M2(10); });

            Task task2 = new Task(() => { M2(10); });
            task2.Start();

            Task<int> task3 = new Task<int>(M3);
            int sum = task3.Result;

            Task<int> task4 = new Task<int> ( () => { return M4(10, 20); });
            task4.Start();
            int a = task4.Result;

            Parallel.Invoke();

            Console.Read();
        }

        static void M1()
        {
            Console.WriteLine("Method 1");
        }
        static void M2(int a)
        {
            Console.WriteLine("Method 2");
        }
        static int M3()
        {
            Console.WriteLine("Method 3");
            return 1;
        }
        static int M4(int a, int v)
        {
            Console.WriteLine("Method 4");
            return a+v;
        }
    }
}
