using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DelegateDemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Developer 1
            // ProcessManager.ShowProcessList(FilterByNone);
            // Developer 2
            //FilterDelegate filter = new FilterDelegate(FilterByName);
            //ProcessManager.ShowProcessList(filter);
            // Developer 3
            //ProcessManager.ShowProcessList(FilterByMemSize);

            ProcessManager.ShowProcessList(delegate (Process p)
            {
                return p.WorkingSet64 >= 100 * 1024 * 1024;
            });

            ProcessManager.ShowProcessList(p => p.WorkingSet64 >= 100 * 1024 * 1024);

            Console.Read();
        }

        // Developer 1
        public static bool FilterByNone(Process p)
        {
            return true;
        }

        // Developer 2
        public static bool FilterByName(Process p)
        {
            if (p.ProcessName.StartsWith("S"))
                return true;
            else
                return false;
        }

        // Developer 3
        //public static bool FilterByMemSize(Process p)
        //{
        //    return p.WorkingSet64 >= 100 * 1024 * 1024;
        //}

    }

    public delegate bool FilterDelegate(Process p);

    // Developer A
    class ProcessManager
    {
        public static void ShowProcessList(FilterDelegate filter)
        {
            foreach (Process p in Process.GetProcesses())
            {
                if (filter(p))
                    Console.WriteLine(p.ProcessName);
            }
        }
    }
}