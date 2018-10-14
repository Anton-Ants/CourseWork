namespace CourseWorkDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LOLj : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Depots", "ProductId");
            DropColumn("dbo.Products", "DepotId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "DepotId", c => c.Int());
            AddColumn("dbo.Depots", "ProductId", c => c.Int());
        }
    }
}
