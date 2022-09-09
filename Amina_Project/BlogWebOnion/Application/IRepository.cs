using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer
{
    internal interface IRepository
    {
        void SortBy(DateTime DateTime);
        IEnumerable<T> GetAll();
        void View();
        void Insert();
        void Update();
        void Delete();
        void SaveChangesAsync();
    }

   
}
