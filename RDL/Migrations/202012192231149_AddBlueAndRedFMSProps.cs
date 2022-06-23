namespace RDL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBlueAndRedFMSProps : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BlueBeacon = c.Int(nullable: false),
                        BlueSeismometer = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RedBeacon = c.Int(nullable: false),
                        RedSeismometer = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Reds");
            DropTable("dbo.Blues");
        }
    }
}
