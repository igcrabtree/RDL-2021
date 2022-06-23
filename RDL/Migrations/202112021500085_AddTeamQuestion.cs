namespace RDL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeamQuestion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TeamQuestions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        teamId = c.Int(nullable: false),
                        questionId = c.Int(nullable: false),
                        qA = c.String(),
                        qB = c.String(),
                        qC = c.String(),
                        qD = c.String(),
                        answer = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TeamQuestions");
        }
    }
}
