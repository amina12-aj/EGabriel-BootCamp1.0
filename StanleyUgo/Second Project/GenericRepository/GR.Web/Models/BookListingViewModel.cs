using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GR.Web.Models
{
    public class BookListingViewModel
    {
        public long Id
        {
            get;
            set;
        }
        public string BookName
        {
            get;
            set;
        }
        public string AuthorName
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
