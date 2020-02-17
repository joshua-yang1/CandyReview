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
        ProductController controller;
        public ProductControllerTests()
        {
            controller = new ProductController();
        }

        [Fact]
        public void Index_Returns_ViewResult()
        { 
            var result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Passes_All_ProductModels_To_View()
        {
            var result = controller.Index();

            Assert.IsAssignableFrom<IEnumerable<ProductModel>>(result.Model);
        }

        [Fact]
        public void Details_Returns_A_View()
        {
            var result = controller.Details(1);

            Assert.IsType<ViewResult>(result);

        }

        [Fact]
        public void Details_Passes_ProductModel_To_View()
        {
            var result = controller.Details(1);

            Assert.IsType<ProductModel>(result.Model);
        }
    }

}
