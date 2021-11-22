using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Program
    {
        public interface IBase
        {
            void A();
        }

        public class Derived1 : IBase
        {
            public void A()
            {
                throw new NotImplementedException();
            }

            public void B1()
            {
                Console.WriteLine("B1");
            }
        }

        public class Derived2 : IBase 
        {
            public void A()
            {
                throw new NotImplementedException();
            }

            public void B2()
            {
                Console.WriteLine("B2");
            }
        }

        static void Main(string[] args)
        {

            IBase d1 = new Derived1();

            IBase d2 = new Derived1();
            
            
            Console.ReadLine();
        }
    }
}
