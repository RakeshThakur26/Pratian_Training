using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Pratian_Training\HandsOn\FileHandlingDemo\sample2.docx";
            //Console.WriteLine("File is " + IsPresent(path)) ;
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine("Hello");
            sw.Close();

            Console.ReadLine();
        }

        private static string IsPresent(string path)
        {
            if (File.Exists(path))
                return "Found";
            return "Not Found";
        }
    }
}
