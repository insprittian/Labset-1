using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Labset_1.Models
{
    public class Post
    {
        [Key]
        public string PostID { get; set; }


        [Required]
        [Display(Name = "Blog Post Title")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Title must be between 5 and 100 characters long")]
        public string Title { get; set; }

        public DateTime PostedDate { get; set; }

        public string Author { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [MinLength(5, ErrorMessage = "Blog Body must be at least 5 characters long")]
        public string Body { get; set; }
    }
}
