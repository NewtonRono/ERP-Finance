using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.LogicalEntities.Domain.FinancialAccounting.Classes
{
    public class SubLedger
    {
        public virtual int Id { get; protected set; }

        public virtual string SubLedgerName { get; protected set; }

        public virtual string LedgerHolderName { get; protected set; }

        public virtual int LedgerId { get; protected set; }

        public virtual Byte SystemLedger { get; protected set; }

        public virtual Ledger ParentLedger { get; protected set; }
               
    }
}
