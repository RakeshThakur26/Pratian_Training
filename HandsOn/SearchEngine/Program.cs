using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SearchEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives = Level1.GetDrives();

            Console.WriteLine("*************************************");
            Console.WriteLine("Level 1");
            Console.WriteLine("*************************************");

            Level1.PrintAllDrives(drives);        

            Console.WriteLine("Enter file name to be searched : ");
            string searchFile = Console.ReadLine();    
          

            Thread level2 = new Thread(() => Level2.SearchFile(searchFile, drives));
            level2.Start();
           // Level2.SearchFile(searchFile, drives);
            

            Thread level3 = new Thread(() => Level3.SearchByParallel(searchFile, drives));
            level3.Start();
            //Level3.SearchByParallel(searchFile, drives);

            Console.Read();
        }      
    }

    
}


