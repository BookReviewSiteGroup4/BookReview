using BookReview.Data;
using BookReview.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReview.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly DbCon _context;

        public StatisticsController(DbCon context)
        {
            _context = context;
        }
        public  IActionResult Index()
        {
            var author = _context.Author.ToList();
            var book = _context.Book.ToList();

            StatisticsViewModel svm = new StatisticsViewModel();

            svm.Author = author;
            svm.Book = book;

            return View(svm);
        }
    }
}
