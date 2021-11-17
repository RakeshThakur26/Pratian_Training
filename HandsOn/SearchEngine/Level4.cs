using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SearchEngine
{
    class Level4
    {
        public static void StoreIntoFile(string filepath, string fname)
        {
            StreamWriter sw = new StreamWriter(@"C:\Pratian_Training\HandsOn\SearchEngine\HistoryData.txt",true);
            sw.WriteLine(filepath + "-" + fname);
            sw.Close();
        }


        public static bool SeachHistory(string fname)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(@"C:\Pratian_Training\HandsOn\SearchEngine\HistoryData.txt");
               
                while (!sr.EndOfStream)
                {
                   string[] history = sr.ReadLine().Split('-');
                    if (history[1].Equals(fname))
                    {
                        Console.WriteLine("File found at " + history[0]);
                        return true;
                    }                      

                }
            }
            finally
            {
                sr.Close();
            }
            return false;
        }
    }
}
