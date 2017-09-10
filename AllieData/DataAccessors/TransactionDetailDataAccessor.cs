﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllieData.DataAccessorInterfaces;
using AllieEntity;

namespace AllieData.DataAccessors
{
    class TransactionDetailDataAccessor : ITransactionDetailDataAccessor
    {
        AllieContext context;
        public TransactionDetailDataAccessor(AllieContext context)
        {
            this.context = context;
        }

        public void Delete(int id)
        {
            TransactionDetail detail = context.TransactionDetails.SingleOrDefault(x => x.Id == id);
            context.TransactionDetails.Remove(detail);
            context.SaveChanges();
        }

        public TransactionDetail Get(int id)
        {
            return context.TransactionDetails.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<TransactionDetail> GetAll()
        {
            return context.TransactionDetails.ToList();
        }

        public IEnumerable<TransactionDetail> GetAll(int transactionId)
        {
            return context.TransactionDetails.Where(x => x.TransactionId == transactionId).ToList();
        }

        public double GetAmount(int id)
        {
            return context.TransactionDetails.SingleOrDefault(x => x.Id == id).Amount;
        }

        public void Insert(TransactionDetail detail)
        {
            context.TransactionDetails.Add(detail);
            context.SaveChanges();
        }

        public void Update(TransactionDetail detail)
        {
            TransactionDetail a = context.TransactionDetails.SingleOrDefault(x => x.Id == detail.Id);

            a.TransactionId = detail.TransactionId;
            a.TransactionType = detail.TransactionType;
            a.Amount = detail.Amount;
            a.AccountId = detail.AccountId;

            context.SaveChanges();
        }
    }
}