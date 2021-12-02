using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using SearchEngineCaseStudy;

namespace SearchEngineCaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Level1 level1 = new Level1();
            level1.DisplayAllDrives();
            string fileName = level1.getFileToBeSearched();

            Level2 level2 = new Level2();
            level2.SearchFile(fileName,level1.drives);
            level2.CloseSearch();



            Console.ReadLine();

        }
    }
    
}