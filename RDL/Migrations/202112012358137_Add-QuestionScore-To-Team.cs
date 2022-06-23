namespace RDL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddQuestionScoreToTeam : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "stemQScore", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "stemQScore");
        }
    }
}
