using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CandyReview.Models;
using Microsoft.AspNetCore.Mvc;


namespace CandyReview.Tests
{
    public class ProductModelTests
    {
        ProductModel model;

        public ProductModelTests()
        {
            model = new ProductModel(1, "Lemonheads", "Sour", "Just okay");
        }


        [Fact]
        public void ProductConstructor_Sets_Id_On_ProductModel()
        {
            var result = model.Id;

            Assert.Equal(1, result);

        }

        [Fact]
        public void ProductConstructor_Sets_Name_On_ProductModel()
        {
            var result = model.Name;

            Assert.Equal("Lemonheads", result);
        }

        [Fact]
        public void ProductConstructor_Sets_Category_On_ProductModel()
        {
            var result = model.Category;

            Assert.Equal("Sour", result);
        }

        [Fact]
        public void ProductConstructor_Sets_Review_On_ProductModel()
        {
            var result = model.Review;

            Assert.Equal("Just okay", result);
        }
    }
}
