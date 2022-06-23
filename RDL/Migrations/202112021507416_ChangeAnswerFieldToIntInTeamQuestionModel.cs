namespace RDL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeAnswerFieldToIntInTeamQuestionModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TeamQuestions", "answer", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TeamQuestions", "answer", c => c.String());
        }
    }
}
