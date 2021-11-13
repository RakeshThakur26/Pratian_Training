using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngine
{
    class Level3
    {
        public static int found = 0;
        public static void SearchByParallel(string fname, DriveInfo[] drives)
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
            if (check(path, fname))
                return true;
            try
            {
               

                string[] folders = Directory.GetDirectories(@path);

                if (folders.Length != 0)
                {
                    foreach (var item in folders)
                    {
                       if( Loop(item, fname))
                        {
                            return true;
                        }
                    }
                }
                else
                   return false;
            }
            catch (Exception)
            {
                return false;
            }
            
                return false;
            
            
        }

        public static bool check(string path, string filename)
        {
            if (File.Exists(@path + "\\" + filename))
            {
                Console.WriteLine("*************************************");
                Console.WriteLine("Level 3");
                Console.WriteLine("File found at " + path);
                Console.WriteLine("*************************************");

                Level4.StoreIntoFile(path, filename);
                found = 1;
                return true;
            }
            return false;
        }

    }
}
