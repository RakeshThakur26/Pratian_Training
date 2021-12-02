using ProductsCatalog.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsCatalog.DataAccess
{
    public class ProductsRepository : IProductsRepository
    {
        private ProductsDbContext db = new ProductsDbContext();
        public bool DeleteProduct(int id)
        {
            db.Products.Remove(db.Products.Find(id));
          return  db.SaveChanges() >= 1;

        }

        public bool EditProduct(Product product)
        {
            db.Entry(product).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges() >= 1;
        }

        public List<Product> GetAllProducts()
        {
            return db.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            return db.Products.Find(id);
        }

        public Product GetProductByName(string name)
        {
            return db.Products.Where(p => p.Name == name).FirstOrDefault();
        }

        public List<Product> GetProductsByBrand(string brand)
        {
            return db.Products.Where(p => p.Brand.Contains(brand)).ToList();
        }

        public List<Product> GetProductsByPrice(int start, int end)
        {
            return db.Products.Where(p => p.Price>= start && p.Price <= end).ToList();
        }

        public Product SaveProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return product;
        }
    }
}
