using System;
using System.Collections.Generic;
using System.Text;

namespace AllieEntity
{
    public class Voucher
    {
        public int VoucherID { get; set; }
        public float Amount { get; set; }
        public int VoucherCreator { get; set; }
        public int VoucherOwner { get; set; }
        public DateTime VoucherValidityDate { get; set; }
        public string VoucherDescription { get; set; }
    }
}
