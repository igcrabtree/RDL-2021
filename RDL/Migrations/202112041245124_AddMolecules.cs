namespace RDL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMolecules : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Scores", "endGame", c => c.Int(nullable: false));
            AddColumn("dbo.Scores", "methane", c => c.Int(nullable: false));
            AddColumn("dbo.Scores", "ethane", c => c.Int(nullable: false));
            AddColumn("dbo.Scores", "butane", c => c.Int(nullable: false));
            AddColumn("dbo.Scores", "pentane", c => c.Int(nullable: false));
            AddColumn("dbo.Scores", "hexane", c => c.Int(nullable: false));
            AddColumn("dbo.Scores", "heptane", c => c.Int(nullable: false));
            AddColumn("dbo.Scores", "octane", c => c.Int(nullable: false));
            AddColumn("dbo.Scores", "nonane", c => c.Int(nullable: false));
            AddColumn("dbo.Scores", "decane", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Scores", "decane");
            DropColumn("dbo.Scores", "nonane");
            DropColumn("dbo.Scores", "octane");
            DropColumn("dbo.Scores", "heptane");
            DropColumn("dbo.Scores", "hexane");
            DropColumn("dbo.Scores", "pentane");
            DropColumn("dbo.Scores", "butane");
            DropColumn("dbo.Scores", "ethane");
            DropColumn("dbo.Scores", "methane");
            DropColumn("dbo.Scores", "endGame");
        }
    }
}
