using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDetails
{
    class Person
    {
        string name;
        int age;
        char sex;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public char Sex
        {
            get { return sex; }
            set { sex = value; }
        }


    }
}
