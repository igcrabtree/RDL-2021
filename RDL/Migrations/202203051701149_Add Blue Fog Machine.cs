namespace RDL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBlueFogMachine : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blues", "fogMachine", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blues", "fogMachine");
        }
    }
}
