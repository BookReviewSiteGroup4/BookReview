using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookReview.Models
{
    public class Book
    {
        [Key] public int Id { get; set; }
        [Required] public string Title { get; set; }
        [Required] public Author Author { get; set; }
        [Required] public string ISBN { get; set; }

        //public int? AuthorID {get;set;}
        public virtual Author author { get; set; }

        //public int? ReviewID { get; set; }
        public virtual IList<Review> Review { get; set; }

    }
}
