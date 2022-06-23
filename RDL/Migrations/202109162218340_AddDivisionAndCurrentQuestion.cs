namespace RDL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDivisionAndCurrentQuestion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blues", "bdivision", c => c.Int(nullable: false));
            AddColumn("dbo.Blues", "currentQuestion", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blues", "currentQuestion");
            DropColumn("dbo.Blues", "bdivision");
        }
    }
}
