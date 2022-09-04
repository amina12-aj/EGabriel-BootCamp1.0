using GR.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR.Data.Interface
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        T Get(long id);
        IQueryable<T> GetQueryable(long id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
