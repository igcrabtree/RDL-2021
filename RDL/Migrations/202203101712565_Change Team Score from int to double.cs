namespace RDL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTeamScorefrominttodouble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Teams", "Score", c => c.Double(nullable: false));
            AlterColumn("dbo.Teams", "Score", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Teams", "Score", c => c.Int(nullable: false));
            AlterColumn("dbo.Teams", "Score", c => c.Int(nullable: false));
        }
    }
}
