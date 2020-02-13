using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using CandyReview.Controllers;

namespace CandyReview.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_Returns_ViewResult()
        {
            var controller = new HomeController();

            var result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}
