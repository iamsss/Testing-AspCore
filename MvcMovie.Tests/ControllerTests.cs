using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.mvc.Controllers;
using MvcMovie.mvc.Models;
using Xunit;
using System.Linq;
using MvcMovie.mvc.Infrastucture;

namespace MvcMovie.Tests
{
    public class ControllerTests
    {
        [Fact]
        public void VerifyIndexViewType()
        {
            

            //Arrange 
            var repository = new InMemoryProductRepository();
            var controller = new HomeController(repository);

            //Act
            var result = controller.Index();

            // Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void VerifyListProductCount()
        {
            //Arrange 
            var repository = new InMemoryProductRepository();
            var controller = new HomeController(repository);

            //Act
            var result =  Assert.IsType<ViewResult>(controller.List());

            var model =  Assert.IsType<List<Product>>(result.Model);

            // Assert
           
            Assert.Equal(2,model.Count());
            
        }
    }
}
