using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class ClsPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string PlaceOfBirth { get; set; }

        public ClsPerson()
        {
            this.Age = 0;
            this.Name = "abc";
            this.PlaceOfBirth = "abc";
        }

        public bool CanVote()
        {
            if (this.Age >= 18)
                return true;
            return false;
        }
    }
}
