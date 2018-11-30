namespace WebPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class link : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Links",
                c => new
                    {
                        LinkID = c.String(nullable: false, maxLength: 128),
                        URL = c.String(maxLength: 256),
                        LinkName = c.String(maxLength: 32),
                    })
                .PrimaryKey(t => t.LinkID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Links");
        }
    }
}
