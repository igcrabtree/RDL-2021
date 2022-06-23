namespace RDL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddQuestionAnsToTeam : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "questionAns", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "questionAns");
        }
    }
}
