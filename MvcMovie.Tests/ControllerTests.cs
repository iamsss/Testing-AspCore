using System;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.mvc.Controllers;
using Xunit;

namespace MvcMovie.Tests
{
    public class ControllerTests
    {
        [Fact]
        public void VerifyIndexViewType()
        {
            //Arrange 
            var controller = new HomeController();

            //Act
            var result = controller.Index();

            // Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
