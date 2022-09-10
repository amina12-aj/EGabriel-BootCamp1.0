using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Gr.Web.Models
{
    public class AuthorViewModel
    {
        [Display(Name = "First Name")]
        public string FirstName
        {
            get;
            set;
        }
        [Display(Name = "Last Name")]
        public string LastName
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
    }
}
