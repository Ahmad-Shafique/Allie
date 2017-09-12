﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllieEntity;
using AllieData.DataAccessorInterfaces;

namespace AllieService.Services
{
    class JournalServices : ServiceInterfaces.IJournalServices
    {
        private IJournalDataAccessor accessor;

        public JournalServices(IJournalDataAccessor accessor)
        {
            this.accessor = accessor;
        }

        public bool Delete(int id)
        {
            return accessor.Delete(id);
        }

        public Journal Get(int id)
        {
            return accessor.Get(id);
        }

        public IEnumerable<Journal> GetAll()
        {
            return accessor.GetAll();
        }

        public bool Insert(Journal journal)
        {
            return accessor.Insert(journal);
        }

        public bool Update(Journal journal)
        {
            return accessor.Update(journal);
        }
    }
}
