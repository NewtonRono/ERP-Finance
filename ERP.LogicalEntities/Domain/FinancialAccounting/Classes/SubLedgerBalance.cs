using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.LogicalEntities.Domain.FinancialAccounting.Classes
{
    public class SubLedgerBalance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }
        public virtual SubLedger SubLedger { get; set; }
        public virtual FinancialYear FinancialYearID { get; set; }
        public virtual decimal DrTotalVoucher { get; protected set; }
        public virtual decimal DrTotalVoucher12 { get; protected set; }
        public virtual decimal DrTotalVoucher11 { get; protected set; }
        public virtual decimal DrTotalVoucher10 { get; protected set; }
        public virtual decimal DrTotalVoucher09 { get; protected set; }
        public virtual decimal DrTotalVoucher08 { get; protected set; }
        public virtual decimal DrTotalVoucher07 { get; protected set; }
        public virtual decimal DrTotalVoucher06 { get; protected set; }
        public virtual decimal DrTotalVoucher05 { get; protected set; }
        public virtual decimal DrTotalVoucher04 { get; protected set; }
        public virtual decimal DrTotalVoucher03 { get; protected set; }
        public virtual decimal DrTotalVoucher02 { get; protected set; }
        public virtual decimal DrTotalVoucher01 { get; protected set; }
        public virtual decimal CrTotalVoucher12 { get; protected set; }
        public virtual decimal CrTotalVoucher11 { get; protected set; }
        public virtual decimal CrTotalVoucher10 { get; protected set; }
        public virtual decimal CrTotalVoucher09 { get; protected set; }
        public virtual decimal CrTotalVoucher08 { get; protected set; }
        public virtual decimal CrTotalVoucher07 { get; protected set; }
        public virtual decimal CrTotalVoucher06 { get; protected set; }
        public virtual decimal CrTotalVoucher05 { get; protected set; }
        public virtual decimal CrTotalVoucher04 { get; protected set; }
        public virtual decimal CrTotalVoucher03 { get; protected set; }
        public virtual decimal CrTotalVoucher02 { get; protected set; }
        public virtual decimal CrTotalVoucher01 { get; protected set; }
        public virtual decimal CrTotalVoucher { get; protected set; }
        public virtual decimal DrOpeningBalance { get; protected set; }
        public virtual decimal CrOpeningBalance { get; protected set; }


    }
}
