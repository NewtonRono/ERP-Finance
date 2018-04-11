namespace ERP.DataModel.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using LogicalEntities.Domain.FinancialAccounting.Classes;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FinancialAccounting.Contexts.ERPContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true; 
        }

        protected override void Seed(FinancialAccounting.Contexts.ERPContext context)
        {
            DbModelBuilder modelBuilder;
            modelBuilder = new DbModelBuilder();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            modelBuilder.HasDefaultSchema("ErpData");
            // modelBuilder.Entity<Group>().Property(t=>t.IsSystemGroup)
            //start from here
            //  modelBuilder.Entity<Group>().HasOptional(g => g.Groups);

            context.Group.AddOrUpdate(
              p => p.GroupName,
              new Group
              {
                  Id = 0,
                  GroupName = "Primary",
                  InternalId = 0,
                  ParentGroupId = 0
              },
               new Group
               {
                   Id = 1001,
                   GroupName = "Assets",
                   InternalId = 0,
                   ParentGroupId = 0
               },
                new Group
                {
                    Id = 1002,
                    GroupName = "Fixed Assets",
                    InternalId = 0,
                    ParentGroupId = 0
                },
                new Group
                {
                    Id = 1003,
                    GroupName = "Current Assets",
                    InternalId = 0,
                    ParentGroupId = 1001
                },
                new Group
                {
                    Id = 1004,
                    GroupName = "Investments",
                    InternalId = 0,
                    ParentGroupId = 1001
                },
                new Group
                {
                    Id = 1005,
                    GroupName = "Misc Expenses",
                    InternalId = 0,
                    ParentGroupId = 1001
                },
                new Group
                {
                    Id = 1006,
                    GroupName = "Cash in Hand",
                    InternalId = 0,
                    ParentGroupId = 1003
                },
                new Group
                {
                    Id = 1007,
                    GroupName = "Sundry Debtors",
                    InternalId = 0,
                    ParentGroupId = 1003
                },
                new Group
                {
                    Id = 1008,
                    GroupName = "Bank Accounts",
                    InternalId = 0,
                    ParentGroupId = 1003
                },
                new Group
                {
                    Id = 1009,
                    GroupName = "Loans & Advances",
                    InternalId = 0,
                    ParentGroupId = 1003
                },
                new Group
                {
                    Id = 1010,
                    GroupName = "Deposits",
                    InternalId = 0,
                    ParentGroupId = 1003
                },
                new Group
                {
                    Id = 1011,
                    GroupName = "Stock in Hand",
                    InternalId = 0,
                    ParentGroupId = 1003
                },
                new Group
                {
                    Id = 2001,
                    GroupName = "Liabilities",
                    InternalId = 0,
                    ParentGroupId = 0
                },
                new Group
                {
                    Id = 2002,
                    GroupName = "Capital Account",
                    InternalId = 0,
                    ParentGroupId = 2001
                },
                new Group
                {
                    Id = 2003,
                    GroupName = "Current Liabilities",
                    InternalId = 0,
                    ParentGroupId = 2001
                },
                new Group
                {
                    Id = 2004,
                    GroupName = "Loans",
                    InternalId = 0,
                    ParentGroupId = 2001
                },
                new Group
                {
                    Id = 2005,
                    GroupName = "Branch Divisons",
                    InternalId = 0,
                    ParentGroupId = 2001
                },
                new Group
                {
                    Id = 2006,
                    GroupName = "Suspense Account",
                    InternalId = 0,
                    ParentGroupId = 2001
                },
                new Group
                {
                    Id = 2007,
                    GroupName = "Reserves & Surplus",
                    InternalId = 0,
                    ParentGroupId = 2002
                },
                new Group
                {
                    Id = 2008,
                    GroupName = "Sundry Creditors",
                    InternalId = 0,
                    ParentGroupId = 2002
                },
                new Group
                {
                    Id = 2009,
                    GroupName = "Provisions",
                    InternalId = 0,
                    ParentGroupId = 2002
                },
                new Group
                {
                    Id = 2010,
                    GroupName = "Duties & Taxes",
                    InternalId = 0,
                    ParentGroupId = 2002
                },
                new Group
                {
                    Id = 2011,
                    GroupName = "Bank OD Accounts",
                    InternalId = 0,
                    ParentGroupId = 2002
                },
                new Group
                {
                    Id = 2012,
                    GroupName = "Secured Loans",
                    InternalId = 0,
                    ParentGroupId = 2004
                },
                new Group
                {
                    Id = 2013,
                    GroupName = "Unsecured Loans",
                    InternalId = 0,
                    ParentGroupId = 2004
                },
               new Group
               {
                   Id = 3001,
                   GroupName = "Income",
                   InternalId = 0,
                   ParentGroupId = 0
               },
               new Group
               {
                   Id = 4001,
                   GroupName = "Expense",
                   InternalId = 0,
                   ParentGroupId = 0
               }
            );



            //context.Groups.AddOrUpdate(
            //  p => p.GroupName,
            //  new LogicalEntities.Domain.FinancialAccounting.Classes.Group
            //  {
            //      Id = 1,
            //      GroupName = "Primary",
            //      ParentGroupId=1

            //  }
            //);


            base.Seed(context);
            context.SaveChanges();
        }
    }
}
