using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using CandyReview.Controllers;
using CandyReview.Models;
using CandyReview.Repositories;
using NSubstitute;

namespace CandyReview.Tests
{ 
    public class ProductControllerTests
    {

        ProductController testController;
        IRepository<ProductModel> productMockRepo;

        public ProductControllerTests()
        {
            productMockRepo = Substitute.For<IRepository<ProductModel>>();
            testController = new ProductController(productMockRepo);     
        }

        [Fact]
        public void Index_Returns_ViewResult()
        {
            var result = testController.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Passes_All_ProductModels_To_View()
        {
            //Arrange
            var expectedProducts = new List<ProductModel>();
            productMockRepo.GetAll().Returns(expectedProducts);

            var result = testController.Index();

            Assert.Equal(expectedProducts, result.Model);

        }

        [Fact]
        public void Details_Returns_A_View()
        {
            var result = testController.Details(1);

            Assert.IsType<ViewResult>(result);

        }

        [Fact]
        public void Details_Passes_ProductModel_To_View()
        {
            var expectedProduct = new ProductModel();
            productMockRepo.GetById(1).Returns(expectedProduct);

            var result = testController.Details(1);

            Assert.Equal(expectedProduct, result.Model);
        }
    }

}
