namespace RDL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestStuff : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "winner", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "winner");
        }
    }
}
