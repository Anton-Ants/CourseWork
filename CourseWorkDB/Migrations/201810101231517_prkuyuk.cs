namespace CourseWorkDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prkuyuk : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "DepotId", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "DepotId");
        }
    }
}
