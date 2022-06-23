namespace RDL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRedFogMachine : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reds", "rFogMachine", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reds", "rFogMachine");
        }
    }
}
