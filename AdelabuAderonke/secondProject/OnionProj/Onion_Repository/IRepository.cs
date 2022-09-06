using Onion_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion_Repository
{
 public interface IRepository<T> where T : BaseEntity
    {
        T Get(int id);
        IEnumerable<T> GetAll();
    }
}
