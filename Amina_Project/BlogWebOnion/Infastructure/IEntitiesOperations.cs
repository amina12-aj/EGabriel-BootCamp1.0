using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfastructureServiceLayer
{
    public interface IEntitiesOperations
    {
        IEnumerable<Task> GetAll();
        void Get(int Id);
        void Insert();
        void Update();
        void Delete();
        void Remove();
    }
}
