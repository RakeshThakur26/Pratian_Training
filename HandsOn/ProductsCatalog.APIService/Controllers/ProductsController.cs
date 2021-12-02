using ProductsCatalog.DataAccess;
using ProductsCatalog.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData;

namespace ProductsCatalog.APIService.Controllers
{
    [Authorize]
    [RoutePrefix("api/products")]
    public class ProductsController : ApiController
    {
        private IProductsRepository repo = new ProductsRepository();

        [EnableQuery]
        public IEnumerable<Product> GetProducts()
        {
            //var result =  repo.GetAllProducts();
            //if (result == null)
            //    return NotFound();
            //return Ok(result);

            return repo.GetAllProducts().AsQueryable();
        }
        [AllowAnonymous]
        public IHttpActionResult GetProductById(int id)
        {
            var p = repo.GetProductById(id);
            if (p == null)
                return NotFound();
            return Ok(p);
        }

        [Route("brand/{brand}")]
        public IHttpActionResult GetProductByBrand(string brand)
        {
            var result = repo.GetProductsByBrand(brand);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [Route("name/{name}")]
        public IHttpActionResult GetProductByName(string name)
        {
            var p = repo.GetProductByName(name);
            if (p == null)
                return NotFound();
            return Ok(p);
        }

        [Route("price/{start}/{end}")]
        public IHttpActionResult GetProductByPrice(int start, int end)
        {
            var result = repo.GetProductsByPrice(start, end);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        public IHttpActionResult DeleteProduct(int id)
        {
            var p = repo.DeleteProduct(id);
            if (p)
                return NotFound();
            return Ok();
        }

        public IHttpActionResult PostProduct(Product product)
        {
            Product p = repo.SaveProduct(product);
            return Created($"api/Products/{p.ProductId}", p);
        }

        public IHttpActionResult PutProduct(Product product)
        {
            bool p = repo.EditProduct(product);

            if (p)
                return Ok();
            return BadRequest();
        }
    }
}
