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
        //public DbSet<Suppliers> Suppliers { get; set; }

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Customers");
            });

            modelBuilder.Entity<Supplier>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Suppliers");
            });

            //modelBuilder.Entity<Customer>().MapToStoredProcedures();
            //modelBuilder.Entity<Supplier>().MapToStoredProcedures();

            modelBuilder.Types().Configure(m => m.MapToStoredProcedures());
        }

    }
}
