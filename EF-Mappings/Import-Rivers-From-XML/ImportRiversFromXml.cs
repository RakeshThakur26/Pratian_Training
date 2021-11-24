using GeographyDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Import_Rivers_From_XML
{
    class ImportRiversFromXml
    {
        static void Main(string[] args)
        {

            var xmlDoc = XDocument.Load(@"C:\Pratian_Training\EF-Mappings\Import-Rivers-From-XML\rivers.xml");
            Console.WriteLine(xmlDoc);

            Console.Read();
        }
    }
}
