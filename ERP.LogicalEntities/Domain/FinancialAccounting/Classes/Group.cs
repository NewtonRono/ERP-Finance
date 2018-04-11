using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.LogicalEntities.Domain.FinancialAccounting.Classes
{
    public class Group
    {
        private IList<Group> _groups = new List<Group>();
        private IList<Ledger> _ledgers = new List<Ledger>();

        [Key]
        
        public virtual int Id { get; set; }

        public virtual int InternalId { get; set; }

        public virtual string GroupName { get; set; }

        public virtual Byte  IsSystemGroup { get;  set; }

        public virtual IList<Ledger> Ledgers
        {
            get { return _ledgers; }
            protected set { _ledgers = value; }
        }

        public virtual IList<Group> Groups
        {
            get { return _groups; }
            protected set { _groups = value; }
        }

        public virtual Group Parent { get; set; }

            }
}
