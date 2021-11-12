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
            // Creating the Queue of type string 
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("String 1");
            queue.Enqueue("String 2");
            queue.Enqueue("String 4");
            queue.Enqueue("String 5");

            // Displaying the Elements presnt in the Queue
            Console.Write("Elements in the Queue : \t");
            foreach (var item in queue)
                Console.Write(item + " ");
            Console.WriteLine();

            // Creating the queue for storing Dequeued elements
            Queue<string> queue2 = new Queue<string>();

            
            int middle = queue.Count / 2;
            for (int i = 0; i < middle; i++)
                queue2.Enqueue(queue.Dequeue());

            // Inserting element in the middle
            queue2.Enqueue("String 3");

            foreach (var item in queue)
                queue2.Enqueue(item);

            queue.Clear();

            foreach (var item in queue2)
                queue.Enqueue(item);

            queue2.Clear();

            // Displaying the Elements present in the queue after insertion
            Console.Write("Elements in the queue after insertion : \t");
            foreach (var item in queue)
                Console.Write(item + " ");

            Console.Read();
        }
    }
}
