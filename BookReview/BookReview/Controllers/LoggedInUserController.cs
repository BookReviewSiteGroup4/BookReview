using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReview.Controllers
{
    public class LoggedInUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
