using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;



namespace ParallelPrg
{
    class Program
    {
        static void Main(string[] args)
        {
            BigData bigData1 = new BigData();
            // Fill 2 million numbers in sequential
            bigData1.Fill(); // fills 1 million
            bigData1.Fill(); // fills 1 million
            Console.WriteLine($"Total count filled with sequential :{bigData1.Size}");

            // Fill 2 million numbers in parallel
            BigData bigData2 = new BigData();
            Parallel.Invoke(bigData2.Fill); // fills 2 million
            Parallel.Invoke(bigData2.Fill); // fills 2 million
            Console.WriteLine($"Total count filled with parallel :{bigData2.Size}");

            Console.Read();

            // TODO: Parallal filling is not filling 2 million numbers. find the bug and fix it
        }
    }



    class BigData
    {
        System.Collections.Concurrent.ConcurrentStack<int> numbers = new System.Collections.Concurrent.ConcurrentStack<int>();
        //private Stack<int> numbers = new Stack<int>();

       // [MethodImpl(MethodImplOptions.Synchronized)]
        public void Fill()
        {
            for (int i = 1; i <= 100000; i++)
            {
                // Monitor.Enter(this);
               // lock (this)
               // {
                    numbers.Push(i);
                //}
                 
               // Monitor.Exit(this);
            }
        }
        public int Size
        {
            get { return numbers.Count; }
        }
    }
}