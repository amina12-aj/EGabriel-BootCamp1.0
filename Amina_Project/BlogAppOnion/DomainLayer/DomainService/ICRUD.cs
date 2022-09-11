using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DomainService
{
   public interface ICRUD
    {
        void Create();
        void Update();
        void Delete();
        void GetAll<list>();
        void Get();
    }
}
