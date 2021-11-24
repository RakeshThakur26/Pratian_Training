using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeographyDataAccess;

namespace Db_AppsSolutions
{
    class ListContinents
    {
        static void Main(string[] args)
        {
            var db = new GeographyEntities();
            foreach (var item in db.Continents)
            {
                Console.WriteLine(item.ContinentName);
            }

            Console.ReadLine();
        }
    }
}
