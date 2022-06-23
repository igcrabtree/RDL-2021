namespace RDL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddQuestionIdToTeam : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "currentQuestionId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "currentQuestionId");
        }
    }
}
