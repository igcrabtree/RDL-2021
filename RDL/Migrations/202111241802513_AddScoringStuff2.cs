namespace RDL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddScoringStuff2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Scores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        siesmometer = c.Int(nullable: false),
                        beacon = c.Int(nullable: false),
                        auv = c.Int(nullable: false),
                        imageRecog = c.Int(nullable: false),
                        satellite = c.Int(nullable: false),
                        hydroPod = c.Int(nullable: false),
                        nitroPod = c.Int(nullable: false),
                        carbonPod = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Scores");
        }
    }
}
