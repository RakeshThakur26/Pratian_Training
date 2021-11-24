using GeographyDataAccess;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web.Script.Serialization;

namespace Export_Rivers_as_JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new GeographyEntities();

            var rivers = db.Rivers.OrderByDescending(r => r.Length).Select(r => new
            {
                r.RiverName,
                r.Length,
                Countries = r.Countries.OrderBy(c => c.CountryName)
                        .Select(c => c.CountryName)
            });

            var javaSerializer = new JavaScriptSerializer();
            var riversJSON = javaSerializer.Serialize(rivers.ToList());
            //Console.WriteLine(riversJSON);

            WriteFile(riversJSON);

            //foreach (var item in rivers)
            //{
            //    Console.WriteLine(item.RiverName +" : ");
            //    foreach (var c in item.Countries)
            //    {
            //        Console.WriteLine("\t" +c);
            //    }
                
            //}

            Console.ReadLine();
        }

        static void WriteFile(string rivers)
        {
            StreamWriter sw = new StreamWriter(@"C:\Pratian_Training\EF-Mappings\rivers.json");
            sw.WriteLine(rivers);
            sw.Close();
        }
    }
}
