using EFProductManagement.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProductManagement.DataAccess
{
    public class ProductsDBContext : DbContext
    {
        public ProductsDBContext() : base("name=ProductsDBContext")
        {

        }
        public DbSet<Product> products { get; set; } 

    }
}
