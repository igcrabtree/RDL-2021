namespace RDL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addfan : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blues", "fan", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blues", "fan");
        }
    }
}
