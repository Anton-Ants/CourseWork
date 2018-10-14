namespace CourseWorkDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class probkkpk : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Depots", "ProductId", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Depots", "ProductId");
        }
    }
}
