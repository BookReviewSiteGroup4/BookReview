using BookReview.Data;
using BookReview.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReview.Controllers
{
    public class BookReviewsController : Controller
    {
        private readonly DbCon dbCon;
        public IActionResult Index()
        {
            return View();
        }

        public IEnumerable<Author> Author { get; set; }

        public async Task OnGet()
        {
            Author = await dbCon.Author.ToListAsync();
        }
    }
}
