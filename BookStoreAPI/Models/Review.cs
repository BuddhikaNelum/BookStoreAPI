using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreAPI.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 10, ErrorMessage ="Headline should be between 10 and 200 characters")]
        public string HeadLine { get; set; }

        [Required]
        [StringLength(2000, MinimumLength = 50, ErrorMessage = "Review Text should be between 10 and 2000 characters")]
        public string ReviewText { get; set; }

        [Required]
        [Range(1,5,ErrorMessage ="Rating must be between 1 and 5 stars")]
        public int Rating { get; set; }
        public virtual Reviewer Reviewer { get; set; }
        public virtual Book Book { get; set; }
    }
}
