using System.Collections.Generic;
using System.Linq;
using MvcMovie.mvc.Core;
using MvcMovie.mvc.Models;

namespace MvcMovie.mvc.Infrastucture
{
    public class InMemoryProductRepository : IProductRepository
    {
        private  List<Product> products = new List<Product> {
               new Product {Id = 1, Name = "Product 1"},
               new Product {Id = 2, Name = "Product 2"}
          };
        public Product GetProductById(int id)
        {
            return products.Where(p => p.Id == id).FirstOrDefault();
        }

        public List<Product> ListProduct()
        {
            return products;
        }
    }
}