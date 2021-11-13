using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngine
{
    class Level1
    {
        public static DriveInfo[] GetDrives()
        {
            return (DriveInfo.GetDrives());
        }

        public static string GetFileName()
        {

            Console.WriteLine("Enter file name to be searched : ");
            string searchFile = Console.ReadLine();
            return searchFile;
        }

        public static void PrintAllDrives(DriveInfo[] drives)
        {
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
        }
    }
}
