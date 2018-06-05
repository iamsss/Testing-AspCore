using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.mvc.Controllers;
using MvcMovie.mvc.Models;
using Xunit;
using System.Linq;
using MvcMovie.mvc.Infrastucture;
using Moq;
using MvcMovie.mvc.Core;

namespace MvcMovie.Tests
{
    public class ControllerTests
    {
        [Fact]
        public void VerifyIndexViewType()
        {
            

            //Arrange 
            var repository = new Mock<IProductRepository>();
            var controller = new HomeController(repository.Object);

            //Act
            var result = controller.Index();

            // Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void VerifyListProductCount()
        {
            //Arrange 
            var repository = new Mock<IProductRepository>();
            repository.Setup(x => x.ListProduct()).Returns(new List<Product>{
                new Product(),new Product()
            });

            var controller = new HomeController(repository.Object);

            //Act
            var result =  Assert.IsType<ViewResult>(controller.List());

            var model =  Assert.IsType<List<Product>>(result.Model);

            // Assert
           
           Assert.Equal(2,model.Count());
            
        }

          [Fact]
        public void VerifyValidId()
        {
            //Arrange 
            var repository = new Mock<IProductRepository>();
            repository.Setup(x => x.GetProductById(It.IsInRange<int>(1,3,Range.Inclusive))).Returns(new Product {
                Id= 1, Name ="Product 1"
            });

            var controller = new HomeController(repository.Object);

            //Act
            var result =  Assert.IsType<ViewResult>(controller.Details(1));

            var model =  Assert.IsType<Product>(result.Model);

            // Assert
           
           Assert.Equal("Product 1",model.Name);
         
        }

           [Fact]
        public void VerifyInValidId()
        {
            //Arrange 
            var repository = new Mock<IProductRepository>();
            repository.Setup(x => x.GetProductById(It.IsInRange<int>(1,3,Range.Inclusive))).Returns(new Product {
                Id= 1, Name ="Product 1"
            });

            var controller = new HomeController(repository.Object);

            //Act
            var result =  Assert.IsType<ViewResult>(controller.Details(6));

           
            // Assert
           
           Assert.Null(result.Model);
         
        }
    }
}
