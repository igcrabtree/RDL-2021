namespace RDL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddQuestionsToScore : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Scores", "stemQs", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Scores", "stemQs");
        }
    }
}
