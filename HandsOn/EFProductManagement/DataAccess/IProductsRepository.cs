using EFProductManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProductManagement.DataAccess
{
    public interface IProductsRepository
    {
        List<Product> GetProducts();//
        Product GetExpensiveProduct();//
        Product GetProduct(int id);//
        Product GetCheapestProduct();//
        Product GetProductByName(string name);//
        List<Product> GetProductsByPrice(int startPrice, int endPrice);
        bool UpdateProduct(Product product);//
        bool SaveProduct(Product product); //
        bool DeleteProductById(int id);//

        bool SaveCatagory(Catagory catagory);
        Catagory GetCatagoryByName(string name);

        List<Catagory> GetProdByCatagoryName(string cat);
    }
}
