namespace ERP.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Groups", "Group_Id", "dbo.Groups");
            DropIndex("dbo.Groups", new[] { "Group_Id" });
            DropColumn("dbo.Groups", "Group_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Groups", "Group_Id", c => c.Int());
            CreateIndex("dbo.Groups", "Group_Id");
            AddForeignKey("dbo.Groups", "Group_Id", "dbo.Groups", "Id");
        }
    }
}
