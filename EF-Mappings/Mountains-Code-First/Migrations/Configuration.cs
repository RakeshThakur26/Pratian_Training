namespace Mountains_Code_First.Migrations
{
    using Mountains_Code_First.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Mountains_Code_First.MountainsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;

            ContextKey = "Mountains_Code_First.MountainsContext";
        }

        protected override void Seed(Mountains_Code_First.MountainsContext context)
        {

            var bulgaria = new Country { Code = "BG", Name = "Bulgaria" };
            context.Countries.Add(bulgaria);

            var rila = new Mountain { Name = "Rila", Countries = { bulgaria } };
            context.Mountains.Add(rila);

            var pirin = new Mountain { Name = "Pirin", Countries = { bulgaria } };
            context.Mountains.Add(pirin);

            var musala = new Peak { Name = "Musala", Elevation = 2299, Mountain = rila };
            context.Peaks.Add(musala);



        }
    }
}
