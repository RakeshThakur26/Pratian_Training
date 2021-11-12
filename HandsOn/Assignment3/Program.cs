using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating the stack of string type
            Stack<string> stack = new Stack<string>();
            stack.Push("String 1");
            stack.Push("String 2");
            stack.Push("String 4");
            stack.Push("String 5");

            // Displaying the Elements presnt in the stack
            Console.WriteLine("Elements in the Stack");
            foreach (var item in stack)
                Console.WriteLine(item);

            // Creating the stack for storing popped elements
            Stack<string> popped = new Stack<string>();

            // Finding middle position to insert element
            int middle ;            
            if(stack.Count % 2 == 0)
                middle = stack.Count/2;
            else
                middle = stack.Count/2 + 1;

            for (int i = 0; i < middle; i++)
                popped.Push(stack.Pop());
          
            stack.Push("String 3");

            foreach (var item in popped)
                stack.Push(item);

            // Displaying the Elements present in the stack after insertion
            Console.WriteLine("Elements in the stack after insertion");
            foreach (var item in stack)
                Console.WriteLine(item);

            // Displaying the top of the stack
            Console.WriteLine("Top of the stack is : " + stack.Peek());

            Console.Read();
        }
    }
}
