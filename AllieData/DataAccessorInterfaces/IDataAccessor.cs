using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllieData.DataAccessorInterfaces
{
    public interface IDataAccessor<T>
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        bool Insert(T Entity);
        bool Update(T Entity);
        bool Delete(int id);
    }
}
