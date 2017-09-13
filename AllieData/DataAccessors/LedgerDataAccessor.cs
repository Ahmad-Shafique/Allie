﻿using AllieData.DataAccessorInterfaces;
using AllieEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllieData.DataAccessors
{
    class LedgerDataAccessor : ILedgerDataAccessor
    {
        AllieContext context;
        public LedgerDataAccessor(AllieContext context)
        {
            this.context = context;
        }

        public void Delete(int id)
        {
            Ledger ledger = context.Ledgers.SingleOrDefault(x => x.Id == id);
            context.Ledgers.Remove(ledger);
            context.SaveChanges();
        }

        public Ledger Get(int id)
        {
            return context.Ledgers.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<Ledger> GetAll()
        {
            return context.Ledgers.ToList();
        }

        public void Insert(Ledger ledger)
        {
           
            context.Ledgers.Add(ledger);
            context.SaveChanges();
        }

        public void Update(Ledger ledger)
        {
           
            Ledger t = context.Ledgers.SingleOrDefault(x => x.Id == ledger.Id);

            t.Id =ledger.Id;
            t.LedgerName = ledger.LedgerName;
            t.LedgerPeriod = ledger.LedgerPeriod;
            t.CompanyId = ledger.CompanyId;
            

            context.SaveChanges();
        }
        
    }
}
