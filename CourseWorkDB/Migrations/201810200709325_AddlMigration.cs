namespace CourseWorkDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddlMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductDepots", "Depot_Id", "dbo.Depots");
            DropForeignKey("dbo.Depots", "Id", "dbo.Stores");
            DropForeignKey("dbo.GoodsSolds", "Store_Id", "dbo.Stores");
            DropIndex("dbo.Depots", new[] { "Id" });
            DropPrimaryKey("dbo.Depots");
            DropPrimaryKey("dbo.Stores");
            AddColumn("dbo.Depots", "StoreId", c => c.Int());
            AlterColumn("dbo.Depots", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Stores", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Depots", "Id");
            AddPrimaryKey("dbo.Stores", "Id");
            CreateIndex("dbo.Stores", "Id");
            AddForeignKey("dbo.ProductDepots", "Depot_Id", "dbo.Depots", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Stores", "Id", "dbo.Depots", "Id");
            AddForeignKey("dbo.GoodsSolds", "Store_Id", "dbo.Stores", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GoodsSolds", "Store_Id", "dbo.Stores");
            DropForeignKey("dbo.Stores", "Id", "dbo.Depots");
            DropForeignKey("dbo.ProductDepots", "Depot_Id", "dbo.Depots");
            DropIndex("dbo.Stores", new[] { "Id" });
            DropPrimaryKey("dbo.Stores");
            DropPrimaryKey("dbo.Depots");
            AlterColumn("dbo.Stores", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Depots", "Id", c => c.Int(nullable: false));
            DropColumn("dbo.Depots", "StoreId");
            AddPrimaryKey("dbo.Stores", "Id");
            AddPrimaryKey("dbo.Depots", "Id");
            CreateIndex("dbo.Depots", "Id");
            AddForeignKey("dbo.GoodsSolds", "Store_Id", "dbo.Stores", "Id");
            AddForeignKey("dbo.Depots", "Id", "dbo.Stores", "Id");
            AddForeignKey("dbo.ProductDepots", "Depot_Id", "dbo.Depots", "Id", cascadeDelete: true);
        }
    }
}
