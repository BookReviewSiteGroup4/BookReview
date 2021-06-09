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
        [Required] public DateTime Birtdate { get; set; }

        public DateTime DeathDate { get; set; }
    }
}
