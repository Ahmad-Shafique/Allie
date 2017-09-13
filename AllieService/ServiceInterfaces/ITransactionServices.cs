﻿using AllieEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllieService.ServiceInterfaces
{
    public interface ITransactionServices
    {
        IEnumerable<Transaction> GetAll();
        IEnumerable<Transaction> GetAll(int companyId);
        IEnumerable<Transaction> GetAll(int companyId, DateTime period);
        Transaction Get(int id);
        void Insert(Transaction tran);
        void Update(Transaction tran);
        void Delete(int id);
    }
}
