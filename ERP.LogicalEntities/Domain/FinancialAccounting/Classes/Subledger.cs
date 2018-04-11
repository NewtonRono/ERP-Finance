using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.LogicalEntities.Domain.FinancialAccounting.Classes
{
    public class SubLedger
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; protected set; }

        public virtual string SubLedgerName { get; protected set; }

        public virtual string LedgerHolderName { get; protected set; }

        public virtual Byte SystemLedger { get; protected set; }

        public virtual Ledger Parent { get; protected set; }

    }
}
