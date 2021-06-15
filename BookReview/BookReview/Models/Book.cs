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
        [Required] public string Description { get; set; }
        public decimal AverageRating { get; set; }
        [Required] public long ISBN { get; set; }

        public int? AuthorID {get;set;}
        public virtual Author Author { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }

    }
}
