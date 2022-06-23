namespace RDL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateStuff : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Scores", "total", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Scores", "total");
        }
    }
}
