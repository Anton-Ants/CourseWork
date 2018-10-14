namespace CourseWorkDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
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
                        ProductType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductTypes", t => t.ProductType_Id)
                .Index(t => t.ProductType_Id);
            
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
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Depots", t => t.Id)
                .Index(t => t.Id);
            
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
            DropForeignKey("dbo.Stores", "Id", "dbo.Depots");
            DropForeignKey("dbo.Products", "ProductType_Id", "dbo.ProductTypes");
            DropForeignKey("dbo.ProductDepots", "Depot_Id", "dbo.Depots");
            DropForeignKey("dbo.ProductDepots", "Product_Id", "dbo.Products");
            DropIndex("dbo.ProductDepots", new[] { "Depot_Id" });
            DropIndex("dbo.ProductDepots", new[] { "Product_Id" });
            DropIndex("dbo.Stores", new[] { "Id" });
            DropIndex("dbo.Products", new[] { "ProductType_Id" });
            DropTable("dbo.ProductDepots");
            DropTable("dbo.Stores");
            DropTable("dbo.ProductTypes");
            DropTable("dbo.Products");
            DropTable("dbo.Depots");
        }
    }
}
