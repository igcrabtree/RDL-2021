namespace RDL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMatchModel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Matches", "RedTeamName");
            DropColumn("dbo.Matches", "BlueTeamName");
            DropColumn("dbo.Matches", "RedTeamScore");
            DropColumn("dbo.Matches", "BlueTeamScore");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Matches", "BlueTeamScore", c => c.Int(nullable: false));
            AddColumn("dbo.Matches", "RedTeamScore", c => c.Int(nullable: false));
            AddColumn("dbo.Matches", "BlueTeamName", c => c.String());
            AddColumn("dbo.Matches", "RedTeamName", c => c.String());
        }
    }
}
