namespace EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class onetomany : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Gender",
                c => new
                    {
                        GenderId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.GenderId);
            
            AddColumn("dbo.User", "Age", c => c.Int(nullable: false));
            AddColumn("dbo.User", "GenderId", c => c.Int(nullable: false));
            AddColumn("dbo.User", "UserName", c => c.String());
            AddColumn("dbo.User", "Password", c => c.String());
            CreateIndex("dbo.User", "GenderId");
            AddForeignKey("dbo.User", "GenderId", "dbo.Gender", "GenderId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User", "GenderId", "dbo.Gender");
            DropIndex("dbo.User", new[] { "GenderId" });
            DropColumn("dbo.User", "Password");
            DropColumn("dbo.User", "UserName");
            DropColumn("dbo.User", "GenderId");
            DropColumn("dbo.User", "Age");
            DropTable("dbo.Gender");
        }
    }
}
