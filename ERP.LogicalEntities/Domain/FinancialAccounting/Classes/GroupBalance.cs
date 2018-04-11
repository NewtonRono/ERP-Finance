using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.LogicalEntities.Domain.FinancialAccounting.Classes
{
    public class GroupBalance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; protected set; }

        public virtual FinancialYear FinancialYearID { get; protected set; }

        public virtual string BaseYear { get; protected set; }

        public virtual Byte IsSystemGroup { get; protected set; }

        public virtual decimal DrTotal { get; protected set; }

        public virtual decimal CrTotal { get; protected set; }

        public virtual decimal DrOpeningBalance { get; protected set; }

        public virtual decimal CrOpeningBalance { get; protected set; }

        public virtual Group ParentID { get; protected set; }

        public virtual int NextFinancialYearID { get; protected set; }


    }
}
