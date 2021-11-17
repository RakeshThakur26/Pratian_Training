using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingDemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch s = Stopwatch.StartNew();
            Console.WriteLine("Task is running..");
            Task task1 = new Task(M1);
            Task task2 = new Task(M2);
            task1.Start();
            task2.Start();        

            task1.Wait();
            task2.Wait();

            Console.WriteLine(s.ElapsedMilliseconds);
            s = Stopwatch.StartNew();
            Console.WriteLine("Parallel task running..");
            Parallel.Invoke(M1,M2);
            Console.WriteLine(s.ElapsedMilliseconds);
            Console.Read();
        }

        static void M1()
        {
            //for (int i = 0; i < 10; i++)
           Parallel.For(0, 10, i => { Thread.Sleep(500); });
        }
        static void M2()
        {
            List<int> arr = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            //for (int i = 0; i < 10; i++)
            Parallel.ForEach(arr, a =>
            {
                Thread.Sleep(500);
            } );
        }
    }
}
