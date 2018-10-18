namespace CourseWorkDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGoodsSold : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Depots",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Weight = c.Double(nullable: false),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        ProductType_Id = c.Int(),
                        GoodsSold_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductTypes", t => t.ProductType_Id)
                .ForeignKey("dbo.GoodsSolds", t => t.GoodsSold_Id)
                .Index(t => t.ProductType_Id)
                .Index(t => t.GoodsSold_Id);
            
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Depots", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.GoodsSolds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.String(),
                        Count = c.Int(nullable: false),
                        Data = c.String(),
                        StoreId = c.String(),
                        Store_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stores", t => t.Store_Id)
                .Index(t => t.Store_Id);
            
            CreateTable(
                "dbo.ProductDepots",
                c => new
                    {
                        Product_Id = c.Int(nullable: false),
                        Depot_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_Id, t.Depot_Id })
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .ForeignKey("dbo.Depots", t => t.Depot_Id, cascadeDelete: true)
                .Index(t => t.Product_Id)
                .Index(t => t.Depot_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GoodsSolds", "Store_Id", "dbo.Stores");
            DropForeignKey("dbo.Products", "GoodsSold_Id", "dbo.GoodsSolds");
            DropForeignKey("dbo.Stores", "Id", "dbo.Depots");
            DropForeignKey("dbo.Products", "ProductType_Id", "dbo.ProductTypes");
            DropForeignKey("dbo.ProductDepots", "Depot_Id", "dbo.Depots");
            DropForeignKey("dbo.ProductDepots", "Product_Id", "dbo.Products");
            DropIndex("dbo.ProductDepots", new[] { "Depot_Id" });
            DropIndex("dbo.ProductDepots", new[] { "Product_Id" });
            DropIndex("dbo.GoodsSolds", new[] { "Store_Id" });
            DropIndex("dbo.Stores", new[] { "Id" });
            DropIndex("dbo.Products", new[] { "GoodsSold_Id" });
            DropIndex("dbo.Products", new[] { "ProductType_Id" });
            DropTable("dbo.ProductDepots");
            DropTable("dbo.GoodsSolds");
            DropTable("dbo.Stores");
            DropTable("dbo.ProductTypes");
            DropTable("dbo.Products");
            DropTable("dbo.Depots");
        }
    }
}
