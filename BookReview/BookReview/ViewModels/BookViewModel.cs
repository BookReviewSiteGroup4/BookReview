using BookReview.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReview.ViewModels
{
    public class BookViewModel
    {
        public Book Book { get; set; }
        public Review Review { get; set; }
    }
}
