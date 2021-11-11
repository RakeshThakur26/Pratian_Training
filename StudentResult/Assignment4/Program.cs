using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("String 1");
            queue.Enqueue("String 2");
            queue.Enqueue("String 4");
            queue.Enqueue("String 5");

            foreach (var item in queue)
                Console.Write(item + " ");
            Console.WriteLine();
         
            Queue<string> queue2 = new Queue<string>();

            int middle = queue.Count / 2;
            for (int i = 0; i < middle; i++)
                queue2.Enqueue(queue.Dequeue());

            queue2.Enqueue("String 3");

            foreach (var item in queue)
                queue2.Enqueue(item);

            queue.Clear();

            foreach (var item in queue2)
                queue.Enqueue(item);

            queue2.Clear();
          
            foreach (var item in queue)
                Console.Write(item + " ");

            Console.Read();
        }
    }
}
