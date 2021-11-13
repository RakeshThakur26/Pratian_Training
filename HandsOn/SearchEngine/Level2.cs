using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngine
{
    class Level2
    {
        public static int found = 0;
        public static void SearchFile(string fname, DriveInfo[] drives)
        {
            Parallel.ForEach(drives, drive =>
            {
                if (check(drive.Name, fname))
                    return;
                else
                {
                    if (Loop(drive.Name, fname))
                        return;
                }
            });

            try
            {
                if (found == 0)
                    throw new FileNotFoundException("The searching file is not found..");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
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
