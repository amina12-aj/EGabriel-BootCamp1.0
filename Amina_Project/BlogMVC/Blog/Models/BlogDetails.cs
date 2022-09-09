using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class BlogDetails
    {
        [Required]
        public int BlogId { get; set; }
        [Required]
        public string Title { get; set; } = default!;
        [Required]
        public string Description { get; set; } = default!;
        [Required]
        public DateTime PublishedDate { get; set; } = DateTime.Now;  



    }
}
