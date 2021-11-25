using GeographyDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Import_Rivers_From_XML
{
    class ImportRiversFromXml
    {
        static void Main(string[] args)
        {

            var xmlDoc = XDocument.Load(@"C:\Pratian_Training\EF-Mappings\Import-Rivers-From-XML\rivers.xml");
            // Console.WriteLine(xmlDoc);

            var riverNodes = xmlDoc.XPathSelectElements("/rivers/river");
            foreach (var item in riverNodes)
            {
                string riverName = item.Element("name").Value;
                int riverLength = Convert.ToInt32( item.Element("length").Value);
                string riverOutflow = item.Element("outflow").Value;

                var countryNodes = item.XPathSelectElements("countries/country");
                var countries = countryNodes.Select(c => c.Value);

                Console.WriteLine($"{riverName} -> {string.Join(", ", countries)}");
            }
            


            Console.Read();
        }
    }
}
