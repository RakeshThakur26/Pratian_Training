using EFProductManagement.DataAccess;
using EFProductManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProductManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch, id;

            ProductsDBContext db = new ProductsDBContext();

            //Supplier supplier = new Supplier
            //{
            //    personId = 121,
            //    FirstName = "Vybhav",
            //    LastName = "a",
            //    Email = "V@email.com",
            //    Address = new Address
            //    {
            //        Area = "abc",
            //        City = "bng"
            //    }
            //};
            //db.People.Add(supplier);

            //var res = db.People.Find(121);
            //db.People.Remove(res);

            //Customer customer = new Customer()
            //{
            //    personId = 111,
            //    FirstName = "Sanket",
            //    LastName = "V",
            //    Type = "Gold",
            //    Address = new Address
            //    {
            //        City = "Bng"
            //    }

            //};

            //db.People.Add(customer);

            Product product = new Product();
            Catagory catagory = new Catagory();
            IProductsRepository repo = new ProductsRepository();
            Console.Write("Enter Product Name : ");
            product.Name = Console.ReadLine();

            Console.Write("Enter price : ");
            product.Price = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Product Description : ");
            product.Description = Console.ReadLine();

            Console.Write("Enter Product brand : ");
            product.Brand = Console.ReadLine();

            Console.Write("Enter catagory name : ");
            string cat = Console.ReadLine();
            product.catagory = repo.GetCatagoryByName(cat);

            repo.SaveProduct(product);


            // db.SaveChanges();


            //var allSup = db.People.OfType<Supplier>().ToList();
            //Console.WriteLine("Suppliers : ");
            //foreach (var item in allSup)
            //{
            //    Console.WriteLine("\t" + item.FirstName);
            //}

            //var allCust = db.People.OfType<Customer>().ToList();
            //Console.WriteLine("\nCustomers : ");
            //foreach (var item in allCust)
            //{
            //    Console.WriteLine("\t" + item.FirstName);
            //}

            Console.ReadLine();

            //while (true)
            //{
            //    Console.WriteLine("*************************************");
            //    Console.WriteLine("CRUD Operation on Product database");
            //    Console.WriteLine("*************************************");
            //    Console.WriteLine("1. Save Product\n2. Update Product \n3. Delete product by id\n4. Display all products");
            //    Console.WriteLine("5. Get product details by id\n6. Get product details by name\n7. Get expensive product");
            //    Console.WriteLine("8. Get cheapest product\n9. Display products between range\n10. Add catagory");
            //    Console.WriteLine("11. Get Products by Catagory");
            //    Console.WriteLine("-------------------------------------");
            //    Console.Write("Please enter your choice : ");
            //    ch = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("-------------------------------------");

            //    Product product = new Product();
            //    Catagory catagory = new Catagory();
            //    IProductsRepository repo = new ProductsRepository();
            //    switch (ch)
            //    {
            //        case 1: Console.WriteLine("Enter product details");
            //            Console.Write("Enter Product Name : ");
            //            product.Name = Console.ReadLine();

            //            Console.Write("Enter price : ");
            //            product.Price = Convert.ToInt32(Console.ReadLine());

            //            Console.Write("Enter Product Description : ");
            //            product.Description = Console.ReadLine();

            //            Console.Write("Enter Product brand : ");
            //            product.Brand = Console.ReadLine();

            //            Console.Write("Enter catagory name : ");
            //            string cat = Console.ReadLine();
            //            product.catagory = repo.GetCatagoryByName(cat);

            //            repo.SaveProduct(product);

            //            Console.WriteLine("-------------------------------------");
            //            Console.WriteLine("Saved successfully...");
            //            Console.WriteLine("-------------------------------------\n");
            //            break;

            //        case 2: Console.Write("Enter product id : ");
            //            id = Convert.ToInt32(Console.ReadLine());
            //            product = repo.GetProduct(id);

            //            Console.Write("Enter new price to be updated : ");
            //            product.Price = Convert.ToInt32(Console.ReadLine());

            //            Console.Write("Enter Description : ");
            //            product.Description = Console.ReadLine();

            //            Console.Write("Enter Brand : ");
            //            product.Brand = Console.ReadLine(); 
            //            Console.Write("Enter catagory name: ");
            //            string catname = Console.ReadLine();

            //            product.catagory = repo.GetCatagoryByName(catname);

            //            repo.UpdateProduct(product);

            //            Console.WriteLine("-------------------------------------");
            //            Console.WriteLine("Updated successfully...");
            //            Console.WriteLine("-------------------------------------\n");
            //            break;

            //        case 3: Console.Write("Enter product id : ");
            //            id = Convert.ToInt32(Console.ReadLine());

            //            repo.DeleteProductById(id);

            //            Console.WriteLine("-------------------------------------");
            //            Console.WriteLine("Deleted successfully...");
            //            Console.WriteLine("-------------------------------------\n");
            //            break;

            //        case 4: var result = repo.GetProducts();

            //            Console.WriteLine("-------------------------------------");
            //            Console.WriteLine("Id\t Name\tPrice\t Description\tBrand\tCatagory");
            //            foreach (var prod in result)
            //                Console.WriteLine(prod.ProductId +"\t"+prod.Name+" \t"+prod.Price +"\t"+prod.Description +" \t"+prod.Brand +" \t" + prod.catagory.Name);

            //            Console.WriteLine("-------------------------------------\n");
            //            break;

            //        case 5:
            //            Console.Write("Enter product id : ");
            //            id = Convert.ToInt32(Console.ReadLine());

            //            Console.WriteLine("-------------------------------------");

            //            var p = repo.GetProduct(id);

            //            Console.WriteLine("Id \t Name\t \tPrice");                       
            //            Console.WriteLine(p.ProductId + " \t" + p.Name + " \t" + p.Price);                        
            //            Console.WriteLine("-------------------------------------\n");
            //            break;

            //        case 6: Console.Write("Enter product name : ");
            //            string name = Console.ReadLine();

            //            Console.WriteLine("-------------------------------------");
            //            p = repo.GetProductByName(name);

            //            Console.WriteLine("Id \t Name\tPrice");
            //            Console.WriteLine(p.ProductId + " \t" + p.Name + " \t" + p.Price);
            //            Console.WriteLine("-------------------------------------\n");
            //            break;

            //        case 7: Console.WriteLine("Expensive product..");

            //            p = repo.GetExpensiveProduct();

            //            Console.WriteLine("-------------------------------------");
            //            Console.WriteLine("Id \t Name\tPrice");
            //            Console.WriteLine(p.ProductId + " \t" + p.Name + " \t" + p.Price);
            //            Console.WriteLine("-------------------------------------\n");
            //            break;

            //        case 8: Console.WriteLine("Cheapest product..");

            //            p = repo.GetCheapestProduct();

            //            Console.WriteLine("-------------------------------------");
            //            Console.WriteLine("Id \t Name\t Price");
            //            Console.WriteLine(p.ProductId + " \t" + p.Name + "\t" + p.Price);
            //            Console.WriteLine("-------------------------------------\n");
            //            break;

            //        case 9:
            //            Console.Write("Enter starting price : ");
            //            int start = Convert.ToInt32(Console.ReadLine());
            //            Console.Write("Enter ending price : ");
            //            int end = Convert.ToInt32(Console.ReadLine());

            //            result = repo.GetProductsByPrice(start, end);

            //            Console.WriteLine(" -------------------------------------");
            //            Console.WriteLine("Id \t Name\t Price");
            //            foreach (var item in result)
            //                Console.WriteLine(item.ProductId + " \t" + item.Name + " \t" + item.Price);
            //            Console.WriteLine("-------------------------------------\n");
            //            break;

            //        case 10:
            //            Console.Write("Enter Catagory name : ");
            //            catagory.Name = Console.ReadLine();

            //            repo.SaveCatagory(catagory);
            //            Console.WriteLine("-------------------------------------\n");
            //            break;

            //        case 11:
            //            Console.Write("Enter Catagory name : ");
            //            cat = Console.ReadLine();

            //            var cats = repo.GetProdByCatagoryName(cat);
            //            Console.WriteLine("-------------------------------------\n");
            //            foreach (var c in cats)
            //            {
            //                Console.WriteLine(c.Name);
            //                foreach (var item in c.Products)
            //                {
            //                    Console.WriteLine("\t" + item.Name);
            //                }
            //            }
            //            Console.WriteLine("-------------------------------------\n");
            //            break;

            //        default: Console.WriteLine("Invalid choice...\n\n"); break;

            //    }
            //}


        }
    }
}
