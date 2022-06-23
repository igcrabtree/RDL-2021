namespace RDL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddQuestionsToTeam : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "questions", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "questions");
        }
    }
}
