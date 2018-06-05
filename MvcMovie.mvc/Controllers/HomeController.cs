using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.mvc.Core;
using MvcMovie.mvc.Models;

namespace MvcMovie.mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository productRespository;

        public HomeController(IProductRepository productRespository)
        {
            this.productRespository = productRespository;

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            var products = productRespository.ListProduct();

            return View(products);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
