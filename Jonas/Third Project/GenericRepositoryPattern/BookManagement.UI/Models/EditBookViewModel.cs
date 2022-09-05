using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookManagement.UI.Models
{
    public class EditBookViewModel
    {
        [Display(Name = "Book Name")]
        public string? BookName { get; set; }
        public string? ISBN { get; set; }
        public string? Publisher { get; set; }
        public List<SelectListItem> Authors { get; set; } = new();

        [Display(Name = "Author")]
        public int AuthorId { get; set; }
    }
}