using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ERP.LogicalEntities.Domain.FinancialAccounting.Classes
{
    public class Ledger
        {
            private IList<SubLedger> _subLedgers = new List<SubLedger>();

            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

            public virtual int Id { get; protected set; }

            public virtual string LedgerName { get; protected set; }

            public virtual string LedgerHolderName { get; protected set; }

            public virtual Byte IsSystemLedger { get; protected set; }

            public virtual int GroupId { get; protected set; }

            public virtual Group ParentGroup { get; protected set; }      

            public virtual IList<SubLedger> SubLedgers
            {
                get { return _subLedgers; }
                set { _subLedgers = value; }
            }
      }
}
