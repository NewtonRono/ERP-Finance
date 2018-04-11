using ERP.Dal.Domain.Classes;
using System.Data.Entity;

namespace ERP.DataModel
{
    public class ERPContext : DbContext
    {
        public DbSet<Group> Groups { get; set;}

        public DbSet<Ledger> Ledgers { get; set; }

        public DbSet<SubLedger> SubLedgers { get; set; }
    }
}
