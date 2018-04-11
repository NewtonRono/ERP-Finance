using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.LogicalEntities.Domain.FinancialAccounting.Classes

{
    public class FinancialYear
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; protected set; }

        public virtual DateTime FinancialYearFrom { get; protected set; }

        public virtual DateTime FinancialYearTo { get; protected set; }

        public virtual DateTime FinancialYearTo1 { get; protected set; }

        public virtual DateTime  MaintainBooksFrom { get; protected set; }

        public virtual Byte BaseYear { get; protected set; }

        public virtual FinancialYear NextFinancialYearId { get; protected set; }

        public virtual Int16 Status { get; protected set; }

    }
}
