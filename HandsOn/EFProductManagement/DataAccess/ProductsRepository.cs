using EFProductManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProductManagement.DataAccess
{
    public class ProductsRepository : IProductsRepository
    {
        ProductsDBContext db = new ProductsDBContext();
        public bool DeleteProductById(int id)
        {
            var del = db.products.Find(id);
            //var del = db.products.Where(p => p.ProductId == id).FirstOrDefault();
            db.products.Remove(del);
            db.SaveChanges();
            return true;
        }

        public Catagory GetCatagoryByName(string name)
        {
            return db.Catagories.Where(c => c.Name.Equals(name)).FirstOrDefault();
        }

        public Product GetCheapestProduct()
        {
            var cheapestProduct = db.products.OrderBy(p => p.Price).FirstOrDefault();
            return cheapestProduct;
        }

        public Product GetExpensiveProduct()
        {
            var expensiveProduct = db.products.OrderByDescending(p => p.Price).FirstOrDefault();
            return expensiveProduct;
        }

        public List<Catagory> GetProdByCatagoryName(string cat)
        {
            return db.Catagories.Where(c => c.Name==cat).ToList();
        }

        public Product GetProduct(int id)
        {
            var result = db.products.Where(p => p.ProductId == id).FirstOrDefault();
            return result;
        }

        public Product GetProductByName(string name)
        {
            var result = db.products.Where(p => p.Name == name).FirstOrDefault();
            return result;
        }

        public List<Product> GetProducts()
        {
            var allProducts = (from pr in db.products.Include("catagory")
                              select pr).ToList();
            return allProducts;
        }

        public List<Product> GetProductsByPrice(int startPrice, int endPrice)
        {            
            var result = db.products.Where(p => (p.Price >=startPrice) && (p.Price <= endPrice)).ToList();
            return result;
        }

        public bool SaveCatagory(Catagory catagory)
        {
            db.Catagories.Add(catagory);
            db.SaveChanges();
            return true;
        }

        public bool SaveProduct(Product product)
        {
            db.products.Add(product);
            db.SaveChanges();
            return true;
        }

        public bool UpdateProduct(Product product)
        {
            //var result = db.products.Where(p => p.ProductId == id).FirstOrDefault();
            //result.Price = price;
            //db.SaveChanges();

            db.Entry(product).State = System.Data.Entity.EntityState.Modified;

            return db.SaveChanges()>=1;
        }
    }
}
