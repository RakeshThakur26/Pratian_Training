using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngine
{
    public class Level2
    {
        public static int found = 0;
        public static int SearchFile(string fname, DriveInfo[] drives)
        {
            Parallel.ForEach(drives, drive =>
            {
                if (check(drive.Name, fname))
                    Loop(drive.Name, fname);
                else
                {
                    Loop(drive.Name, fname);                       
                }
            });

                if (found == 0)
                    throw new FileNotFoundException("The searching file is not found..");
            
            return found;
            
        }

        public static bool Loop(string path, string fname)
        {           
            try
            {
                if (check(path, fname))
                    return true;

                string[] folders = Directory.GetDirectories(@path);

                if (folders.Length != 0)
                {
                    foreach (var item in folders)
                    {
                        Loop(item, fname);
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool check(string path, string filename)
        {
            if (File.Exists(@path + "\\" + filename))
            {
                found = 1;
                Console.WriteLine("*************************************");
                Console.WriteLine("Level 2");
                Console.WriteLine("File found at " + path);
                Console.WriteLine("*************************************");
               
                return true;
            }
            return false;
        }

    }
}
