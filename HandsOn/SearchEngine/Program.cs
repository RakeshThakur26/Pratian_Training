using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            Console.WriteLine("Drives in the system are : ");
            foreach (var item in drives)
            {
                string active;
                if (item.IsReady)
                    active = "Active";
                else
                    active = "Inactive";
                Console.WriteLine("Drive " + item + " is " + active);
                
            }

            Console.WriteLine("Enter file name to be searched : ");
            string searchFile = Console.ReadLine();


            Console.Read();
        }

       
    }
}
