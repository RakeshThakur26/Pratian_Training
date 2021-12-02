using ProductsCatalog.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsCatalog.DataAccess
{
    internal class ProductsDbContext : DbContext
    {
        public ProductsDbContext() : base("name=ProductCatalogDB")
        {

        }

        public  DbSet<Product> Products { get; set; }
    }
}
