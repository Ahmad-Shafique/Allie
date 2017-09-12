﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllieEntity;

namespace AllieService.ServiceInterfaces
{
    public interface IJournalServices
    {
        IEnumerable<Journal> GetAll();
        Journal Get(int id);
        bool Insert(Journal journal);
        bool Update(Journal journal);
        bool Delete(int id);
    }
}