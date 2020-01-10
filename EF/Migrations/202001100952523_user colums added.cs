namespace EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usercolumsadded : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Users", newName: "User");
            AddColumn("dbo.User", "Name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "Name");
            RenameTable(name: "dbo.User", newName: "Users");
        }
    }
}
