﻿using AllieData.DataAccessorInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllieEntity;

namespace AllieData.DataAccessors
{
    // for the time being only get all and insert is done...
    class CompanyDataAccessor : ICompanyDataAccessor
    {
        private AllieContext context;
        public CompanyDataAccessor(AllieContext context)
        {
            this.context = context;
        }

        public Company Insert(Company company)
        {
            context.Companies.Add(company);
            context.SaveChanges();
            return context.Companies.SingleOrDefault(x => x.CompanyName == company.CompanyName);
        }

        public void Delete(int id)
        {
            Company c = context.Companies.SingleOrDefault(x =>x.Id == id);
            context.Companies.Remove(c);
            context.SaveChanges();
        }

        public void Update(Company company)
        {
            Company c = context.Companies.SingleOrDefault(x => x.Id == company.Id);

            c.CompanyName = company.CompanyName;
            c.Location = company.Location;
            c.Mail = company.Mail;
            c.Phone = company.Phone;

            context.SaveChanges();
        }

        public Company Get(int id)
        {
            return context.Companies.SingleOrDefault(x => x.Id == id);
        }
        public Company Get(string name)
        {
            return context.Companies.SingleOrDefault(x => x.CompanyName == name);
        }

        public IEnumerable<Company> GetAll()
        {
            return context.Companies.ToList();
        }
    }
}
