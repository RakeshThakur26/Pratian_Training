using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SearchEngineCaseStudy
{
    class Level2
    {
        public static int fileFound = 0;
        public static string[] filePath = { "" };
 
        public void CloseSearch()
        {
            Console.WriteLine("---------File Search Ended!---------");
            Console.WriteLine("File Found at "+fileFound+" locations");
        }

        public void SearchFile(string fileName, DriveInfo[] drives)
        {
            foreach (var drive in drives)
            {
                if (check(drive.Name, fileName))
                    Loop(drive.Name, fileName);
                else
                    Loop(drive.Name, fileName);
            }

            try
            {
                if (fileFound == 0)
                    throw new FileNotFoundException("The File you are Searching for doesn't Exist :( ");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public bool Loop(string path, string fileName)
        {
            try
            {
                if (check(path, fileName))
                    Loop(path, fileName);

                string[] folders = Directory.GetDirectories(@path);

                if (folders.Length != 0)
                {
                    foreach (var content in folders)
                    {
                        Loop(content, fileName);
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool check(string path, string filename)
        {
            if (File.Exists(@path + "\\" + filename))
            {
                Console.WriteLine("File Found at " + path);
                filePath[fileFound++] = path;
                //Console.WriteLine("Printing "+filePath[fileFound]);
                return true;
            }
            return false;
        }

    }
}
