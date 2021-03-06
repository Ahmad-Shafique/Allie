﻿using AllieData.DataAccessorInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllieEntity;

namespace AllieData.DataAccessors
{
    class IncomeStatementDataAccessor : IIncomeStatementDataAccessor
    {
        AllieContext context;
        public IncomeStatementDataAccessor(AllieContext context)
        {
            this.context = context;
        }

        public void Delete(int id)
        {
            IncomeStatement state =  context.IncomeStatements.SingleOrDefault(x => x.Id == id);
            context.IncomeStatements.Remove(state);
            context.SaveChanges();
        }

        public IncomeStatement Get(int id)
        {
            return context.IncomeStatements.SingleOrDefault(x => x.Id == id);
        }

        public IncomeStatement Get(DateTime start, DateTime end)
        {
            return context.IncomeStatements.SingleOrDefault(x => x.Start.Month == start.Month &&
                                                               x.Start.Year == start.Year &&
                                                               x.End.Month == end.Month &&
                                                               x.End.Year == end.Year );
        }

        public IEnumerable<IncomeStatement> GetAll()
        {
            return context.IncomeStatements.ToList();
        }

        public IEnumerable<IncomeStatement> GetAll(int companyId)
        {
            return context.IncomeStatements.Where(x=>x.CompanyId == companyId).ToList();
        }

        public void Insert(IncomeStatement statement)
        {
            context.IncomeStatements.Add(statement);
            context.SaveChanges();
        }

        public void Update(IncomeStatement statement)
        {
            IncomeStatement state = context.IncomeStatements.SingleOrDefault(x => x.Id == statement.Id);

            state.Start = statement.Start;
            state.End = statement.End;
            state.Total = statement.Total;
            state.Description = statement.Description;

            context.SaveChanges();
        }
    }
}
