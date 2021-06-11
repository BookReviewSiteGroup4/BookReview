using BookReview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReview.ViewModels
{
    public class StatisticsViewModel
    {
        public List<Author> Author { get; set; }
        public List<Book> Book { get; set; }
    }
}
