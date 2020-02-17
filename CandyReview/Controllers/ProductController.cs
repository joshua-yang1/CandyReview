using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CandyReview.Models;
using CandyReview.Repositories;

namespace CandyReview.Controllers
{
    public class ProductController : Controller
    {
        public ViewResult Index()
        {
            ProductRepository productRepo = new ProductRepository();
            var model = productRepo.GetAll();
            return View(model);
        }
    }
}