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
            var author = _context.Author.Include(a => a.Books).ThenInclude(e => e.Reviews).ToList();
            var book = _context.Book.Include(b => b.Reviews).ToList();

            StatisticsViewModel svm = new StatisticsViewModel();

            svm.Author = author;
            svm.Book = book;
            return View(svm);
        }

        public IActionResult TopAuthor()
        {
            var topAuthor = _context.Author.Include(a => a.Books).ThenInclude(e => e.Reviews).ToList();
            var filterAuthor = topAuthor.Where(a => a.Books.Any(b => b.Reviews.Any()));
            var getTopAuthors = filterAuthor.OrderByDescending(o => o.Books.Where(w => w.Reviews.Any()).Average(a => a.Reviews.Average(r => r.ReviewScore))).Take(3);

            return View(getTopAuthors);
        }

        public IActionResult BestReviews()
        {
            var books = _context.Book.Include(a => a.Author).ThenInclude(x => x.Books).ThenInclude(w => w.Reviews).ToList();
            var filterBooks = books.Where(a => a.Reviews.Any());
            var filter3 = filterBooks.OrderByDescending(o => o.Reviews.Average(a => a.ReviewScore)).Take(3);

            foreach (var item in filter3)
            {
                item.AverageRating = item.Reviews.Average(a => a.ReviewScore);
            }
            return View(filter3);
        }
    }
}
