namespace CourseWorkDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDellMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductDepots", "Depot_Id", "dbo.Depots");
            DropForeignKey("dbo.Stores", "Id", "dbo.Depots");
            DropForeignKey("dbo.GoodsSolds", "Store_Id", "dbo.Stores");
            DropIndex("dbo.Stores", new[] { "Id" });
            DropPrimaryKey("dbo.Depots");
            DropPrimaryKey("dbo.Stores");
            AddColumn("dbo.Stores", "DepotId", c => c.Int());
            AlterColumn("dbo.Depots", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Stores", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Depots", "Id");
            AddPrimaryKey("dbo.Stores", "Id");
            CreateIndex("dbo.Depots", "Id");
            AddForeignKey("dbo.ProductDepots", "Depot_Id", "dbo.Depots", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Depots", "Id", "dbo.Stores", "Id");
            AddForeignKey("dbo.GoodsSolds", "Store_Id", "dbo.Stores", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GoodsSolds", "Store_Id", "dbo.Stores");
            DropForeignKey("dbo.Depots", "Id", "dbo.Stores");
            DropForeignKey("dbo.ProductDepots", "Depot_Id", "dbo.Depots");
            DropIndex("dbo.Depots", new[] { "Id" });
            DropPrimaryKey("dbo.Stores");
            DropPrimaryKey("dbo.Depots");
            AlterColumn("dbo.Stores", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Depots", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Stores", "DepotId");
            AddPrimaryKey("dbo.Stores", "Id");
            AddPrimaryKey("dbo.Depots", "Id");
            CreateIndex("dbo.Stores", "Id");
            AddForeignKey("dbo.GoodsSolds", "Store_Id", "dbo.Stores", "Id");
            AddForeignKey("dbo.Stores", "Id", "dbo.Depots", "Id");
            AddForeignKey("dbo.ProductDepots", "Depot_Id", "dbo.Depots", "Id", cascadeDelete: true);
        }
    }
}
