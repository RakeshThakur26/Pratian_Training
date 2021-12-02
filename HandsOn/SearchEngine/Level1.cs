using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngine
{
    public class Level1
    {
        bool act = false;
        public static DriveInfo[] GetDrives()
        {
            return (DriveInfo.GetDrives());
        }
       
        public bool PrintAllDrives(DriveInfo[] drives)
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("Level 1");          

            Console.WriteLine("Drives in the system are : ");
            foreach (var item in drives)
            {
                string active;
                if (item.IsReady)
                {
                    active = "Active";
                    this.act = true;
                }                    
                else
                    active = "Inactive";
                Console.WriteLine("Drive " + item + " is " + active);
            }
            Console.WriteLine("*************************************");
            return act;
        }
    }
}
