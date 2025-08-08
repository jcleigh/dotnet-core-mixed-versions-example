using NUnit.Framework;
using DotNetCoreThreePointOne.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using DotNetCoreThreePointOne.Web.Models;
using Microsoft.AspNetCore.Http;

namespace DotNetCoreThreePointOne.Test
{
    public class HomeControllerTests
    {
        [Test]
        public void Index_ReturnsViewResult()
        {
            var loggerMock = new Mock<ILogger<HomeController>>();
            var controller = new HomeController(loggerMock.Object);
            var result = controller.Index();
            Assert.IsInstanceOf<ViewResult>(result);
        }

        [Test]
        public void Privacy_ReturnsViewResult()
        {
            var loggerMock = new Mock<ILogger<HomeController>>();
            var controller = new HomeController(loggerMock.Object);
            var result = controller.Privacy();
            Assert.IsInstanceOf<ViewResult>(result);
        }

        [Test]
        public void Error_ReturnsViewResultWithErrorViewModel()
        {
            var loggerMock = new Mock<ILogger<HomeController>>();
            var controller = new HomeController(loggerMock.Object);
            // Set up a mock HttpContext to avoid NullReferenceException
            var httpContext = new DefaultHttpContext();
            controller.ControllerContext = new ControllerContext
            {
                HttpContext = httpContext
            };
            var result = controller.Error();
            var viewResult = result as ViewResult;
            Assert.IsNotNull(viewResult);
            Assert.IsInstanceOf<ErrorViewModel>(viewResult.Model);
        }
    }
}
