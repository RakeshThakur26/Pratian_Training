using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngineCaseStudy
{
    class Level1
    {
        public DriveInfo[] drives = DriveInfo.GetDrives();
        public DriveInfo[] getDrives()
        {
            drives = DriveInfo.GetDrives();
            return drives;
        }
        public void showDrives()
        {
            Console.WriteLine("--------Displaying Drives in your System--------");
            foreach (DriveInfo drive in drives)
                Console.WriteLine(drive.Name + " Drive " + (drive.IsReady ? "is Active": "is Not Active"));
            Console.WriteLine("------------------------------------------------");
        }

        public void DisplayAllDrives()
        {
            getDrives();
            showDrives();
        }
        public string getFileToBeSearched()
        {
            Console.WriteLine("\nEnter the file to be Searched in your System");
            return Console.ReadLine();
        }
    }
}
