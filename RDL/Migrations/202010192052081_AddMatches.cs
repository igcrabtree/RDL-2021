namespace RDL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMatches : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RedTeamID = c.Int(nullable: false),
                        BlueTeamID = c.Int(nullable: false),
                        RedTeamName = c.String(),
                        BlueTeamName = c.String(),
                        RedTeamScore = c.Int(nullable: false),
                        BlueTeamScore = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Matches");
        }
    }
}
