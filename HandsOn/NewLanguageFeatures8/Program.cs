using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewLanguageFeatures6;

namespace NewLanguageFeatures8
{
    class Program
    {
        static void Query()
        {
            var stores = CreateStores();
            var numLondon = stores.Count(s => s.City == "London");
            Console.WriteLine("There are {0} stores in London. ", numLondon);
            Console.Read();
        }
        static void Main(string[] args)
        {
            Query();
        }
        public static List<Customer> FindCustomersByCity(List<Customer> customers, string city)
        {
            return customers.FindAll(c => c.City == city);
        }

        static List<Store> CreateStores()
        {
            return new List<Store>
             {
                 new Store { Name = "Jim’s Hardware", City = "Berlin" },
                 new Store { Name = "John’s Books", City = "London" },
                 new Store { Name = "Lisa’s Flowers", City = "Torino" },
                 new Store { Name = "Dana’s Hardware", City = "London" },
                 new Store { Name = "Tim’s Pets", City = "Portland" },
                 new Store { Name = "Scott’s Books", City = "London" },
                 new Store { Name = "Paula’s Cafe", City = "Marseille" }
             };
        }
    }

    public class Store
    {
        public string Name { get; set; }
        public string City { get; set; }
        public override string ToString()
        {
            return Name + "\t" + City;
        }
    }

}
