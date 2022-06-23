namespace RDL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
               "dbo.Testing",
               c => new
               {
                   Id = c.Int(nullable: false, identity: true),
                   Switch = c.Int(nullable: false),
               })
               .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            DropTable("dbo.Testing");
        }
    }
}
