using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string");
            string input = Console.ReadLine();
            int acount=0,ecount=0,icount=0,ocount=0,ucount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if(IsOwel(input[i]))
                    {
                    switch (input[i])
                    {
                        case 'a':acount++;break;
                        case 'e':ecount++;break;
                        case 'i':icount++;break;
                        case 'o':ocount++;break;
                        case 'u':ucount++;break;
                    }
                }
            }
            if (acount > ecount && acount > icount && acount > ocount && acount > ucount)
                Console.WriteLine("a");
            if (ecount > acount && ecount > icount && ecount > ocount && ecount > ucount)
                Console.WriteLine("e");
            if (icount > acount && icount > ecount && icount > ocount && icount > ucount)
                Console.WriteLine("i");
            if (ocount > acount && ocount > ecount && ocount > ucount && ocount > ucount)
                Console.WriteLine("o");
            if (ucount > acount && ucount > icount && ucount > ocount && ucount > ecount)
                Console.WriteLine("u");

        }
        static bool IsOwel(char ch)
        {
            return ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u'; 
        }
    }
}
