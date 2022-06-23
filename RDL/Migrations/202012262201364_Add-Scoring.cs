namespace RDL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddScoring : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Scorings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PointsInAuto = c.Int(nullable: false),
                        PointsInTele = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Scorings");
        }
    }
}
