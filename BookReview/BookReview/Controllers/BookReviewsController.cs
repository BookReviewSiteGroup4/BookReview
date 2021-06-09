using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReview.Controllers
{
    public class BookReviewsController : Controller
    {
        Dbcon dbCon = new Dbcon();
        public IActionResult Index()
        {
            return View();
        }
    }
}
