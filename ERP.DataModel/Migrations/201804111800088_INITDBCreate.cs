namespace ERP.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INITDBCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FinancialYears",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FinancialYearFrom = c.DateTime(nullable: false),
                        FinancialYearTo = c.DateTime(nullable: false),
                        MaintainBooksFrom = c.DateTime(nullable: false),
                        BaseYear = c.Byte(nullable: false),
                        Status = c.Short(nullable: false),
                        NextFinancialYearId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FinancialYears", t => t.NextFinancialYearId_Id)
                .Index(t => t.NextFinancialYearId_Id);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InternalId = c.Int(nullable: false),
                        GroupName = c.String(),
                        IsSystemGroup = c.Byte(nullable: false),
                        Parent_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.Parent_Id)
                .Index(t => t.Parent_Id);
            
            CreateTable(
                "dbo.Ledgers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LedgerName = c.String(),
                        LedgerHolderName = c.String(),
                        IsSystemLedger = c.Byte(nullable: false),
                        Parent_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.Parent_Id)
                .Index(t => t.Parent_Id);
            
            CreateTable(
                "dbo.SubLedgers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubLedgerName = c.String(),
                        LedgerHolderName = c.String(),
                        SystemLedger = c.Byte(nullable: false),
                        Parent_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ledgers", t => t.Parent_Id)
                .Index(t => t.Parent_Id);
            
            CreateTable(
                "dbo.LedgerBalances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DrTotalVoucher = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DrTotalVoucher12 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DrTotalVoucher11 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DrTotalVoucher10 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DrTotalVoucher09 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DrTotalVoucher08 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DrTotalVoucher07 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DrTotalVoucher06 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DrTotalVoucher05 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DrTotalVoucher04 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DrTotalVoucher03 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DrTotalVoucher02 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DrTotalVoucher01 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CrTotalVoucher12 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CrTotalVoucher11 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CrTotalVoucher10 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CrTotalVoucher09 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CrTotalVoucher08 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CrTotalVoucher07 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CrTotalVoucher06 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CrTotalVoucher05 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CrTotalVoucher04 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CrTotalVoucher03 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CrTotalVoucher02 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CrTotalVoucher01 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CrTotalVoucher = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DrOpeningBalance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CrOpeningBalance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FinancialYearID_Id = c.Int(),
                        Ledger_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FinancialYears", t => t.FinancialYearID_Id)
                .ForeignKey("dbo.Ledgers", t => t.Ledger_Id)
                .Index(t => t.FinancialYearID_Id)
                .Index(t => t.Ledger_Id);
            
            CreateTable(
                "dbo.SubLedgerBalances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DrTotalVoucher = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DrTotalVoucher12 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DrTotalVoucher11 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DrTotalVoucher10 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DrTotalVoucher09 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DrTotalVoucher08 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DrTotalVoucher07 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DrTotalVoucher06 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DrTotalVoucher05 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DrTotalVoucher04 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DrTotalVoucher03 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DrTotalVoucher02 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DrTotalVoucher01 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CrTotalVoucher12 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CrTotalVoucher11 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CrTotalVoucher10 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CrTotalVoucher09 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CrTotalVoucher08 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CrTotalVoucher07 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CrTotalVoucher06 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CrTotalVoucher05 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CrTotalVoucher04 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CrTotalVoucher03 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CrTotalVoucher02 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CrTotalVoucher01 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CrTotalVoucher = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DrOpeningBalance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CrOpeningBalance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FinancialYearID_Id = c.Int(),
                        SubLedger_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FinancialYears", t => t.FinancialYearID_Id)
                .ForeignKey("dbo.SubLedgers", t => t.SubLedger_Id)
                .Index(t => t.FinancialYearID_Id)
                .Index(t => t.SubLedger_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubLedgerBalances", "SubLedger_Id", "dbo.SubLedgers");
            DropForeignKey("dbo.SubLedgerBalances", "FinancialYearID_Id", "dbo.FinancialYears");
            DropForeignKey("dbo.LedgerBalances", "Ledger_Id", "dbo.Ledgers");
            DropForeignKey("dbo.LedgerBalances", "FinancialYearID_Id", "dbo.FinancialYears");
            DropForeignKey("dbo.SubLedgers", "Parent_Id", "dbo.Ledgers");
            DropForeignKey("dbo.Ledgers", "Parent_Id", "dbo.Groups");
            DropForeignKey("dbo.Groups", "Parent_Id", "dbo.Groups");
            DropForeignKey("dbo.FinancialYears", "NextFinancialYearId_Id", "dbo.FinancialYears");
            DropIndex("dbo.SubLedgerBalances", new[] { "SubLedger_Id" });
            DropIndex("dbo.SubLedgerBalances", new[] { "FinancialYearID_Id" });
            DropIndex("dbo.LedgerBalances", new[] { "Ledger_Id" });
            DropIndex("dbo.LedgerBalances", new[] { "FinancialYearID_Id" });
            DropIndex("dbo.SubLedgers", new[] { "Parent_Id" });
            DropIndex("dbo.Ledgers", new[] { "Parent_Id" });
            DropIndex("dbo.Groups", new[] { "Parent_Id" });
            DropIndex("dbo.FinancialYears", new[] { "NextFinancialYearId_Id" });
            DropTable("dbo.SubLedgerBalances");
            DropTable("dbo.LedgerBalances");
            DropTable("dbo.SubLedgers");
            DropTable("dbo.Ledgers");
            DropTable("dbo.Groups");
            DropTable("dbo.FinancialYears");
        }
    }
}
