using System.ComponentModel.DataAnnotations;

namespace BookReview.Models
{
    public class Review
    {
        [Key] public int Id { get; set; }
        [Required] public string Title { get; set; }
        [Required] public string Description { get; set; }
        [Required] public decimal ReviewScore { get; set; }
        public virtual Book book { get; set; }
    }
}