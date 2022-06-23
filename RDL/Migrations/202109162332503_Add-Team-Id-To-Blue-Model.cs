namespace RDL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeamIdToBlueModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blues", "TeamId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blues", "TeamId");
        }
    }
}
