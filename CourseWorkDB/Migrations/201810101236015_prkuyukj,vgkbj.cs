namespace CourseWorkDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prkuyukjvgkbj : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Stores", new[] { "Id" });
            DropPrimaryKey("dbo.Stores");
            AlterColumn("dbo.Stores", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Stores", "Id");
            CreateIndex("dbo.Stores", "Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Stores", new[] { "Id" });
            DropPrimaryKey("dbo.Stores");
            AlterColumn("dbo.Stores", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Stores", "Id");
            CreateIndex("dbo.Stores", "Id");
        }
    }
}
