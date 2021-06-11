using System.ComponentModel.DataAnnotations;

namespace BookReview.Models
{
    public class Review
    {
        [Key] public int Id { get; set; }
        [Required] public string Title { get; set; }
        [Required] public string Description { get; set; }
        [Required]
        [Range(1, 5)]
        public decimal ReviewScore { get; set; }
        public int? BookID { get; set; }        
        public virtual Book book { get; set; }
    }
}