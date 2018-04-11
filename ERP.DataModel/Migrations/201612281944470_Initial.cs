namespace ERP.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        InternalId = c.Int(nullable: false),
                        GroupName = c.String(),
                        IsSystemGroup = c.Byte(nullable: false),
                        ParentGroupId = c.Int(nullable: false),
                        something = c.Int(nullable: false),
                        Group_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.Group_Id)
                .Index(t => t.Group_Id);
            
            CreateTable(
                "dbo.Ledgers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LedgerName = c.String(),
                        LedgerHoderName = c.String(),
                        IsSystemLedger = c.Byte(nullable: false),
                        GroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.GroupId, cascadeDelete: true)
                .Index(t => t.GroupId);
            
            CreateTable(
                "dbo.SubLedgers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubLedgerName = c.String(),
                        LedgerHolderName = c.String(),
                        LedgerId = c.Int(nullable: false),
                        SystemLedger = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ledgers", t => t.LedgerId, cascadeDelete: true)
                .Index(t => t.LedgerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubLedgers", "LedgerId", "dbo.Ledgers");
            DropForeignKey("dbo.Ledgers", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.Groups", "Group_Id", "dbo.Groups");
            DropIndex("dbo.SubLedgers", new[] { "LedgerId" });
            DropIndex("dbo.Ledgers", new[] { "GroupId" });
            DropIndex("dbo.Groups", new[] { "Group_Id" });
            DropTable("dbo.SubLedgers");
            DropTable("dbo.Ledgers");
            DropTable("dbo.Groups");
        }
    }
}
