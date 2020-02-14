using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CandyReview.Models;

namespace CandyReview.Controllers
{
    public class ProductController : Controller
    {
        public ViewResult Index()
        {
            var model = new ProductModel();
            return View(model);
        }
    }
}