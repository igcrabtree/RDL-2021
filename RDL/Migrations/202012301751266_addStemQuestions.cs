namespace RDL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addStemQuestions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StemQuestions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Question = c.String(),
                        AnswerA = c.String(),
                        AnswerB = c.String(),
                        AnswerC = c.String(),
                        AnswerD = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StemQuestions");
        }
    }
}
