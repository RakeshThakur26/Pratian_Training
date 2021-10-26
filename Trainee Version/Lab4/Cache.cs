using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4
{
    class Cache
    {
        private static int MAX_CAPACITY = 0;   

        // Assigning the capacity to MAX_CAPACITY variable
        public static void SetMaxCapacity(int capacity) 
        {
		    MAX_CAPACITY = capacity;
	    }
      
        public static int GetMaxCapacity() 
        {
		    Console.WriteLine("Returning MAX_CAPACITY");         
		    return MAX_CAPACITY;
	    }
    }
}
