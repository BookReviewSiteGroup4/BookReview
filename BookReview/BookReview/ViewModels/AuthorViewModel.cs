using BookReview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReview.ViewModels
{
    public class AuthorViewModel
    {
        public Author Author { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
