namespace RDL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateColors : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blues", "bBeacon", c => c.Int(nullable: false));
            AddColumn("dbo.Blues", "bSeismometer", c => c.Int(nullable: false));
            AddColumn("dbo.Reds", "rBeacon", c => c.Int(nullable: false));
            AddColumn("dbo.Reds", "rSeismometer", c => c.Int(nullable: false));
            DropColumn("dbo.Blues", "blueBeacon");
            DropColumn("dbo.Blues", "blueSeismometer");
            DropColumn("dbo.Reds", "redBeacon");
            DropColumn("dbo.Reds", "redSeismometer");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reds", "redSeismometer", c => c.Int(nullable: false));
            AddColumn("dbo.Reds", "redBeacon", c => c.Int(nullable: false));
            AddColumn("dbo.Blues", "blueSeismometer", c => c.Int(nullable: false));
            AddColumn("dbo.Blues", "blueBeacon", c => c.Int(nullable: false));
            DropColumn("dbo.Reds", "rSeismometer");
            DropColumn("dbo.Reds", "rBeacon");
            DropColumn("dbo.Blues", "bSeismometer");
            DropColumn("dbo.Blues", "bBeacon");
        }
    }
}
