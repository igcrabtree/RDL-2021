namespace RDL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLocation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "City", c => c.String());
            AddColumn("dbo.Teams", "State", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "State");
            DropColumn("dbo.Teams", "City");
        }
    }
}
