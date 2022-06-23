namespace RDL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDivisionToTeamModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "division", c => c.Int(nullable: false));
            DropColumn("dbo.Blues", "bdivision");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Blues", "bdivision", c => c.Int(nullable: false));
            DropColumn("dbo.Teams", "division");
        }
    }
}
