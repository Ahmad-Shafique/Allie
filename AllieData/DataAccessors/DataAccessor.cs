using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllieData.DataAccessors
{
    //To be completed
    /*
    class DataAccessor<T, TEntity> : DataAccessorInterfaces.IDataAccessor<T>
    {
        private DbSet EntityDbSet;

        private AllieContext Context;

        public DataAccessor(AllieContext context, string EntityName){
            Context = context;
            EntityDbSet = context.Set(Type.GetType(EntityName));
            //EntityDbSet = context.Set<TEntity>();


        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            return Context.EntityDbSet.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Insert(T acc)
        {
            throw new NotImplementedException();
        }

        public bool Update(T acc)
        {
            throw new NotImplementedException();
        }
    }
    */
}
