using ProductsCatalog.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsCatalog.DataAccess
{
    public interface IProductsRepository
    {
        Product SaveProduct(Product product);
        bool DeleteProduct(int id);
        bool EditProduct(Product product);
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        Product GetProductByName(string name);
        List<Product> GetProductsByBrand(string brand);
        List<Product> GetProductsByPrice(int start, int end);

    }
}
