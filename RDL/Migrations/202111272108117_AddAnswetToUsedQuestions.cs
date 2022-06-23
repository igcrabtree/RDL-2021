namespace RDL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnswetToUsedQuestions : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UsedQuestions", "answe", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UsedQuestions", "answe");
        }
    }
}
