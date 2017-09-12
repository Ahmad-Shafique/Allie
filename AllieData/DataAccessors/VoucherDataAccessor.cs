using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllieEntity;

namespace AllieData.DataAccessors
{
    class VoucherDataAccessor : DataAccessorInterfaces.IVoucherDataAccessor
    {
        private AllieContext Context;

        public VoucherDataAccessor(AllieContext Context)
        {
            this.Context = Context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Voucher Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Voucher> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Insert(Voucher voucher)
        {
            throw new NotImplementedException();
        }

        public bool Update(Voucher voucher)
        {
            throw new NotImplementedException();
        }
    }
}
