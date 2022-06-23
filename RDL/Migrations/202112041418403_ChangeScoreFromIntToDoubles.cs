namespace RDL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeScoreFromIntToDoubles : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Scores", "total", c => c.Double(nullable: false));
            AlterColumn("dbo.Scores", "methane", c => c.Double(nullable: false));
            AlterColumn("dbo.Scores", "ethane", c => c.Double(nullable: false));
            AlterColumn("dbo.Scores", "butane", c => c.Double(nullable: false));
            AlterColumn("dbo.Scores", "pentane", c => c.Double(nullable: false));
            AlterColumn("dbo.Scores", "hexane", c => c.Double(nullable: false));
            AlterColumn("dbo.Scores", "heptane", c => c.Double(nullable: false));
            AlterColumn("dbo.Scores", "octane", c => c.Double(nullable: false));
            AlterColumn("dbo.Scores", "nonane", c => c.Double(nullable: false));
            AlterColumn("dbo.Scores", "decane", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Scores", "decane", c => c.Int(nullable: false));
            AlterColumn("dbo.Scores", "nonane", c => c.Int(nullable: false));
            AlterColumn("dbo.Scores", "octane", c => c.Int(nullable: false));
            AlterColumn("dbo.Scores", "heptane", c => c.Int(nullable: false));
            AlterColumn("dbo.Scores", "hexane", c => c.Int(nullable: false));
            AlterColumn("dbo.Scores", "pentane", c => c.Int(nullable: false));
            AlterColumn("dbo.Scores", "butane", c => c.Int(nullable: false));
            AlterColumn("dbo.Scores", "ethane", c => c.Int(nullable: false));
            AlterColumn("dbo.Scores", "methane", c => c.Int(nullable: false));
            AlterColumn("dbo.Scores", "total", c => c.Int(nullable: false));
        }
    }
}
