using System.ComponentModel.DataAnnotations;

namespace GR.Web.Models
{
    public class AddBookModel
    {
        [Display(Name = "Book Name")]
        public string BookName {get; set;}
        public string Category {get; set;}
        public string ISBN {get; set;}
        public string Publisher {get; set;}
    }
}