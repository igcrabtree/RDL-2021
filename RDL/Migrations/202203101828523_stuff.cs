namespace RDL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stuff : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Teams", "Score", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Teams", "Score", c => c.Int(nullable: false));
        }
    }
}
