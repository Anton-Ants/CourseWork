namespace CourseWorkDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LOLj3 : DbMigration
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
