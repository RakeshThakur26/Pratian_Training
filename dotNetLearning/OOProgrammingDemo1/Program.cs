using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProgrammingDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Organization org = new Organization();
            //org.SetName("Pratian");
            //org.name = "Pratiansdfsdfsdfd";
            org.Name = "Pratian";
            //Console.WriteLine(org.GetName()) ;
            //Console.WriteLine(org.name);
            Console.WriteLine(org.Name);
        }
    }
}
