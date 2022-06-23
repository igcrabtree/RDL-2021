namespace RDL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStuffToRedModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reds", "teamId", c => c.Int(nullable: false));
            AddColumn("dbo.Reds", "currentQuestion", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reds", "currentQuestion");
            DropColumn("dbo.Reds", "teamId");
        }
    }
}
