using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CandyReview.Controllers
{
    public class ProductController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}