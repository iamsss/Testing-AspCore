using System.Collections.Generic;
using MvcMovie.mvc.Models;

namespace MvcMovie.mvc.Core
{
    public interface IProductRepository
    {
        List<Product> ListProduct();
        Product GetProductById(int id);
    }
}