using GeographyDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Export_Monasteries_as_XML
{
    class ExportMonasteriesAsXml
    {
        static void Main(string[] args)
        {
            var db = new GeographyEntities();

            var countries = db.Countries.Where(c => c.Monasteries.Any())
                .OrderBy(c => c.CountryName)
                .Select(c => new
                {
                    c.CountryName, 
                    Monasteries = c.Monasteries.
                    OrderBy(m => m.Name)
                    .Select(m => m.Name)
                });

            var xmlMonasteries = new XElement("monasteries");

            foreach (var c in countries)
            {
                var xmlCountries = new XElement("country");
                xmlCountries.Add(new XAttribute("name", c.CountryName));
               
                xmlMonasteries.Add(xmlCountries);

                int i = 1;
                foreach (var m in c.Monasteries)
                {                    
                    xmlCountries.Add(new XAttribute("monastery"+i, m));
                    i++;
                }
                
            }

            var xmlDoc = new XDocument(xmlMonasteries);
            xmlDoc.Save(@"C:\Pratian_Training\EF-Mappings\monesteries.xml");

            Console.ReadLine();
        }
    }
}
