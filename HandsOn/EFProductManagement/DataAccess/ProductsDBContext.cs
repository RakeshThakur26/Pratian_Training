using EFProductManagement.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProductManagement.DataAccess
{
    internal class ProductsDBContext : DbContext
    {
        public ProductsDBContext() : base("name=ProductsDBContext")
        {

        }
        public DbSet<Product> products { get; set; } 
        public DbSet<Catagory> Catagories { get; set; }

    }
}
