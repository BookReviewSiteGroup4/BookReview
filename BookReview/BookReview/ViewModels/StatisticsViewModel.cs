using BookReview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReview.ViewModels
{
    public class StatisticsViewModel
    {
        public IEnumerable<Author> Author { get; set; }
        public IEnumerable<Book> Book { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
    }
}
