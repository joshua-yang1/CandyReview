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
        IRepository<ProductModel> productRepo;

        public ProductController(IRepository<ProductModel> productRepo)
        {
            this.productRepo = productRepo;
        }

        public ViewResult Index()
        {
            var model = productRepo.GetAll();

            return View(model);
        }

        public ViewResult Details(int id)
        {
            ProductModel model = productRepo.GetById(id);

            return View(model);
        }


    }
}