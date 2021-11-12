using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace HandsOn1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Pratian_Training\HandsOn\HandsOn1\names.txt";
            string path2 = @"C:\Pratian_Training\HandsOn\HandsOn1\Sortednames.txt";

            string[] names = FileRead(path);
            Calculate(names, path2);
            Console.Read();
        }

        private static string[] FileRead(string path)
        {
            StreamReader sr = new StreamReader(path);
            string allNames = sr.ReadToEnd().Replace("\"","");

            string[] names = allNames.Split(',');
            
            sr.Close();
            Array.Sort(names);
            return names;

            //List<string> namesList = new List<string>(names);
            //namesList.Sort();
            //return namesList;

        }

        private static void Calculate(string[] names, string path2)
        {
            StreamWriter sw = new StreamWriter(path2);
            int count = 1;
            int total = 0;
            foreach (var item in names)
            {
                int stringTotal = 0;
                Console.Write(item + " : ");
                sw.Write(item + " : ");
                
                for (int i = 0; i < item.Length; i++)
                {
                    int val = item[i] + 1 - 'A';
                    Console.Write(val + " for '" + item[i] + "' + ");
                    
                    sw.Write(val + " for '" + item[i] + "' + ");

                    stringTotal += val;
                }

                Console.WriteLine(" = " + stringTotal +" and product = " + (count * stringTotal));

                sw.WriteLine(" = " + stringTotal + " and product = " + (count * stringTotal));

                count++;
                total += stringTotal;               
            }
            sw.WriteLine("*****************************************************************************************************************");
            sw.WriteLine("Total sum = " + total);
            sw.Close();
            Console.WriteLine("*****************************************************************************************************************");

            Console.WriteLine("Total sum = " + total);
        }
    }
}
