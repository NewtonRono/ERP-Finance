using ERP.LogicalEntities.Domain.FinancialAccounting.Classes;
using System.Data.Entity;

namespace ERP.DataModel.FinancialAccounting.Contexts
{
    public class ERPContext : DbContext
    {
        public DbSet<Group> Group { get; set;}

        public DbSet<Ledger> Ledger { get; set; }

        public DbSet<SubLedger> SubLedger { get; set; }
    }
}
