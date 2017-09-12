using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllieEntity;

namespace AllieData.DataAccessors
{
    class JournalDataAccessor : DataAccessorInterfaces.IJournalDataAccessor
    {
        private AllieContext Context;

        public JournalDataAccessor(AllieContext Context)
        {
            this.Context = Context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Journal Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Journal> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Insert(Journal journal)
        {
            throw new NotImplementedException();
        }

        public bool Update(Journal journal)
        {
            throw new NotImplementedException();
        }
    }
}
