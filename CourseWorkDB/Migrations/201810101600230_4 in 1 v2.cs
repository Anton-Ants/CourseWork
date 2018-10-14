namespace CourseWorkDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _4in1v2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductDepots", "Depot_Id", "dbo.Depots");
            DropForeignKey("dbo.Depots", "Id", "dbo.Stores");
            DropIndex("dbo.Depots", new[] { "Id" });
            DropPrimaryKey("dbo.Depots");
            DropPrimaryKey("dbo.Stores");
            AlterColumn("dbo.Depots", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Stores", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Depots", "Id");
            AddPrimaryKey("dbo.Stores", "Id");
            CreateIndex("dbo.Stores", "Id");
            AddForeignKey("dbo.ProductDepots", "Depot_Id", "dbo.Depots", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Stores", "Id", "dbo.Depots", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stores", "Id", "dbo.Depots");
            DropForeignKey("dbo.ProductDepots", "Depot_Id", "dbo.Depots");
            DropIndex("dbo.Stores", new[] { "Id" });
            DropPrimaryKey("dbo.Stores");
            DropPrimaryKey("dbo.Depots");
            AlterColumn("dbo.Stores", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Depots", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Stores", "Id");
            AddPrimaryKey("dbo.Depots", "Id");
            CreateIndex("dbo.Depots", "Id");
            AddForeignKey("dbo.Depots", "Id", "dbo.Stores", "Id");
            AddForeignKey("dbo.ProductDepots", "Depot_Id", "dbo.Depots", "Id", cascadeDelete: true);
        }
    }
}
