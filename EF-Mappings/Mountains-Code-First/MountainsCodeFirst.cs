using Mountains_Code_First.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mountains_Code_First
{
    class MountainsCodeFirst
    {
        static void Main(string[] args)
        {
            MountainsContext db = new MountainsContext();

            //Country c1 = new Country();
            //c1.Code = "SP";
            //c1.Name = "Spain";

            //db.Countries.Add(c1);

         //   Database.SetInitializer(new MountainMigrationStratergy());

            //Country c = new Country { Code = "UK", Name = "United KingDom" };
            //Mountain m = new Mountain { Name = "UK Hills" };
            //m.Peaks.Add(new Peak() { Name="Great peak", Mountain=m});
            //m.Peaks.Add(new Peak() { Name="Small peak", Mountain=m});
            //c.Mountains.Add(m);

            //db.Countries.Add(c);

            //db.SaveChanges();
            

            Console.Read();
        }
    }
}
