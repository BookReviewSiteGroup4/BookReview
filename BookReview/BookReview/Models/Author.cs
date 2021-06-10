using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookReview.Models
{
    public class Author
    {
        [Key] public int Id { get; set; }
        [Required] public string FullName { get; set; }

        [Required] 
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)] 
        public DateTime Birtdate { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime? DeathDate { get; set; }
        public virtual IList<Book> Books { get; set; }
    }
}
