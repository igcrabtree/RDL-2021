namespace RDL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddteamIdtoScore : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Scores", "teamId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Scores", "teamId");
        }
    }
}
