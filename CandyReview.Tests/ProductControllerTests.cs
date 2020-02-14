using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using CandyReview.Controllers;
using CandyReview.Models;

namespace CandyReview.Tests
{
    public class ProductControllerTests
    {
        [Fact]
        public void Index_Returns_ViewResult()
        {
            var controller = new ProductController();

            var result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Passes_ProductModel_To_View()
        {
            var controller = new ProductController();

            var result = controller.Index();

            Assert.IsType<ProductModel>(result.Model);

        }
    }

}
