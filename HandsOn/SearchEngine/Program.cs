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

            Level1 level1 = new Level1();
            level1.PrintAllDrives(drives);
            Console.WriteLine();

            Console.WriteLine("Enter file name to be searched : ");
            string searchFile = Console.ReadLine();

            try
            {
                if (!Level4.SeachHistory(searchFile))
                {
                   // Console.WriteLine("File is not found in search history..\nSearching in System drives");
                    
                    Thread level2 = new Thread(() => Level2.SearchFile(searchFile, drives));
                    level2.Start();
                    // Level2.SearchFile(searchFile, drives);
                    Console.WriteLine();

                    Thread level3 = new Thread(() => Level3.SearchByParallel(searchFile, drives));
                    level3.Start();
                    //Level3.SearchByParallel(searchFile, drives);
                    Console.WriteLine();
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }      
    }

    
}


