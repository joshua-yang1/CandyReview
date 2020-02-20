using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CandyReview.Models;
using CandyReview.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CandyReview.Controllers
{
    public class ReviewController : Controller
    {
        IRepository<ReviewModel> reviewRepo;

        public ReviewController(IRepository<ReviewModel> reviewRepo)
        {
            this.reviewRepo = reviewRepo;
        }

        public ViewResult Index()
        {
            var model = reviewRepo.GetAll();

            return View(model);
        }

    }
}
