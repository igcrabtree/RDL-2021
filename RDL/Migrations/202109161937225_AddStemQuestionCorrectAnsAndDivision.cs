namespace RDL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStemQuestionCorrectAnsAndDivision : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StemQuestions", "correctAns", c => c.Int(nullable: false));
            AddColumn("dbo.StemQuestions", "division", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.StemQuestions", "division");
            DropColumn("dbo.StemQuestions", "correctAns");
        }
    }
}
