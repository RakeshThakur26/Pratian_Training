using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Pratian_Training\HandsOn\FileHandlingDemo\sample.txt";
            ReadFromFile(path);

            List<Employee> employees = LoadEmployee(path);
            int total = employees.Sum(obj => obj.Salary);
            Console.WriteLine("Total salary = " + total);
            Console.WriteLine();

            //SaveEmployeeDetails(path, employees);

            //DeleteEmployee(path, 123);

            //UpdateEmployee(path,111);

            ReadFromFileLineByLine(path);
            Console.Read();
        }

        private static void DeleteEmployee(string path, int id)
        {
            StreamReader sr = null;
            string str = "";
            try
            {
                sr = new StreamReader(path);
                string line;
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    string[] data = line.Split(',');
                    if(Convert.ToInt32(data[0]) == id )
                    {
                        //line.Remove(0);
                        //return;
                    }
                    else
                    {
                        str += line + "\n";
                    }
                }
            }
            finally
            {
                sr.Close();
                WriteFile(path, str);
            }
        }

        private static void UpdateEmployee(string path, int id)
        {
            StreamReader sr = null;
            string str = "";
            try
            {
                sr = new StreamReader(path);
                string line;
                
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    
                    string[] data = line.Split(',');
                    if (line.Contains(id.ToString()))
                    {
                        str += data[0] + ",Rakesh," + data[2] + "\n";
                    }
                    else
                        str += line + "\n";
                }
            }
            finally
            {
                sr.Close();
                WriteFile(path, str);
            }
        }

        public static void SaveEmployeeDetails(string path, List<Employee> employees)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(path, true);
                foreach (var item in employees)
                {
                    sw.WriteLine(item.Id + "," + item.Name + "," + item.Salary);
                }
               
            }
            finally
            {
                sw.Close();
            }
        }

        public static List<Employee> LoadEmployee(string path)
        {
            StreamReader sr = null;
            List<Employee> employees = new List<Employee>();
            try
            {
                sr = new StreamReader(path);
                
                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] data = line.Split(',');
                    Employee emp = new Employee();
                    emp.Id = Convert.ToInt32(data[0]);
                    emp.Name = data[1];
                    emp.Salary = Convert.ToInt32(data[2]);
                    employees.Add(emp);
                }                
            }
            finally
            {
                sr.Close();
            }
            return employees;
        }
        public static void ReadFromFile(string path)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(path);
                Console.WriteLine("Reading once");
                Console.WriteLine(sr.ReadToEnd());
            }
            finally
            {
                sr.Close();
            }      
           
        }
        public static void ReadFromFileLineByLine(string path)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(path);
                string line;
                Console.WriteLine("Reading line by line");
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            finally
            {
                sr.Close();
            }      
           
        }

        public static void WriteIntoFile(string path)
        {
            // true is for appending data to preveous data
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(path);
                sw.WriteLine("Hello, This is file handling demo");                
            }
            finally
            {
                sw.Close();
            }

        }
        
        public static void WriteFile(string path, string msg)
        {
            // true is for appending data to preveous data
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(path);
                sw.WriteLine(msg);                
            }
            finally
            {
                sw.Close();
            }

        }
    }
}
