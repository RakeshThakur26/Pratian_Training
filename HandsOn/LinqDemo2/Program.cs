using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo2
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Product> products = ProductsDB.GetProducts();
			//1. List all products whose price in between 50K to 80K 
			var result1 = products.Where(obj => obj.Price >= 50000 && obj.Price <= 80000);
            Console.WriteLine("All products whose price in between 50K to 80K ");
            foreach (var item in result1)
            {
                Console.WriteLine(item.Name + "\t" + item.Catagory.Name + "\t" + item.Price);
            }

            Console.WriteLine("***********************************\n");

            
			
			//2. Extract all products belongs to Laptops catagory
            Console.WriteLine("All products belongs to Laptops catagory");
			var result2 = products.Where(obj => obj.Catagory.Name.Equals("Laptops"));
			foreach (var item in result2)
			{
				Console.WriteLine(item.Name + "\t" + item.Catagory.Name + "\t" + item.Price);
			}
			Console.WriteLine("***********************************\n");

           
			
			//3. Extract/Show Product Name and Catagory Name only
            Console.WriteLine("Product Name and Catagory Name only");
			var result3 = from p in products
						  select new { prod = p.Name, cat = p.Catagory.Name };
			foreach (var item in products)
			{
				Console.WriteLine(item.Name + "\t" + item.Catagory.Name);
			}
			Console.WriteLine("***********************************\n");


			int i = 1;
			//4. Show the costliest product name
			
            Console.WriteLine("Costliest product");
			var result4 = products.OrderByDescending(obj => obj.Price).First();
			Console.WriteLine(result4.Name + "\t" + result4.Price);
			Console.WriteLine("***********************************\n");



			//5. Show the cheepest product name and its price
			var result5 = products.OrderBy(obj => obj.Price).First();
            Console.WriteLine("cheepest product name and its price");
			Console.WriteLine(result5.Name + "\t" + result5.Price);
			
			Console.WriteLine("***********************************\n");



            //6. Show the 2nd and 3rd product details
            Console.WriteLine("2nd and 3rd product details");
            //Console.WriteLine("ProdName\tprodId\tPrice\tCategoryName");
            Console.WriteLine(products[1].Name + "\t\t" + products[1].ProductID+"\t"+ products[1].Price+ "\t"+ products[1].Catagory.Name);
            Console.WriteLine(products[2].Name + "\t" + products[2].ProductID+"\t"+ products[2].Price+ "\t"+ products[2].Catagory.Name);
			Console.WriteLine("***********************************\n");



			//7. List all products in assending order of their price
			var result7 = products.OrderBy(obj => obj.Price);
            Console.WriteLine("All products in assending order of their price");
			foreach (var item in result7)
			{
				Console.WriteLine(item.Name + "\t" + item.Price);
			}
			Console.WriteLine("***********************************\n");


			//8. Count the no. of products belong to Tablets
			var result8 = products.Where(obj => obj.Catagory.Name == "Tablets").Count();
            Console.WriteLine("Count the no. of products belong to Tablets");
            Console.WriteLine(result8);
			Console.WriteLine("***********************************\n");


			//9. Show which catagory has costly product
			var result9 = products.OrderByDescending(obj => obj.Price).FirstOrDefault();
            Console.WriteLine("catagory which has costly product");
            Console.WriteLine("Product name\tPrice\tCategory");
			Console.WriteLine(result4.Name + "\t" + result4.Price +"\t" + result4.Catagory.Name);
			Console.WriteLine("***********************************\n");

			//10. Show which catagory has less products }
			Console.WriteLine("catagory which has less products");
			Console.WriteLine("Category\tCount");

			var result10 = products.GroupBy(obj => obj.Catagory.Name).Select(group => new { cat = group.Key, count = group.Count() }).OrderBy(x => x.count).ToList();
			
			Console.WriteLine(result10[0].cat + " \t" + result10[0].count);
			Console.WriteLine("***********************************\n");


			Console.ReadLine();
		}
		
		
	}
	class ProductsDB
	{
		public static List<Product> GetProducts()
		{
			Catagory cat1 = new Catagory { CatagoryID = 101, Name = "Laptops" };
			Catagory cat2 = new Catagory { CatagoryID = 201, Name = "Mobiles" };
			Catagory cat3 = new Catagory { CatagoryID = 301, Name = "Tablets" };

			Product p1 = new Product { ProductID = 1, Name = "Dell XPS 13", Catagory = cat1, Price = 90000 };
			Product p2 = new Product { ProductID = 2, Name = "HP 430", Catagory = cat1, Price = 50000 };
			Product p3 = new Product { ProductID = 3, Name = "IPhone 6", Catagory = cat2, Price = 80000 };
			Product p4 = new Product { ProductID = 4, Name = "Galaxy S6", Catagory = cat2, Price = 74000 };
			Product p5 = new Product { ProductID = 5, Name = "IPad Pro", Catagory = cat3, Price = 44000 };

			cat1.Products.Add(p1);
			cat1.Products.Add(p2);
			cat2.Products.Add(p3);
			cat2.Products.Add(p4);
			cat3.Products.Add(p5);

			List<Product> products = new List<Product>();
			products.Add(p1);
			products.Add(p2);
			products.Add(p3);
			products.Add(p4);
			products.Add(p5);
			return products;
		}
	}
	class Product
	{
		public int ProductID { get; set; }
		public string Name { get; set; }
		public int Price { get; set; }
		public Catagory Catagory { get; set; }
	}
	class Catagory
	{
		public int CatagoryID { get; set; }
		public string Name { get; set; }
		public List<Product> Products = new List<Product>();
	}
}
