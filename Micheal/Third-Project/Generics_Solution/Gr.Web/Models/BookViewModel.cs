using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Gr.Web.Models
{
    public class BookViewModel
    {
        [Display(Name = "Book Name")]
        public string BookName
        {
            get;
            set;
        }
        public string ISBN
        {
            get;
            set;
        }
        public string Publisher
        {
            get;
            set;
        }
    }
}
