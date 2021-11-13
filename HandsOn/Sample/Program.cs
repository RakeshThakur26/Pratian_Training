using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Program
    {
        static bool GetInfo(DirectoryInfo dinfo, string filename)
        {
            FileInfo[] files = null;
            DirectoryInfo[] directories = null;
            try
            {
                files = dinfo.GetFiles();
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
            }
            if (files != null)
            {
                foreach (var item in files)
                {
                    if (item.Name == filename) { Console.WriteLine(item.DirectoryName + "Found"); return true; }
                    //Console.WriteLine(item);

                }
            }
            try
            {
                directories = dinfo.GetDirectories();
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
            }
            if (directories != null)
            {
                foreach (var item in directories)
                {
                    //Console.WriteLine("-----------------");
                    //Console.WriteLine(item);
                    if (GetInfo(item, filename))
                    {
                        //Console.WriteLine(item.Name + " Found ");
                        return true;
                    }
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (var item in drives)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.IsReady);
            }

            Console.WriteLine("Enter the file to be searched:");
            string filename = Console.ReadLine();

            foreach (var item in drives)
            {
                DirectoryInfo directoryInfo = item.RootDirectory;
                //new DirectoryInfo(@"C:\Users\K Sneha Lalitha\Desktop\Pratian Training")
                GetInfo(directoryInfo, filename);
            }
            Console.ReadLine();

        }
    }
}
