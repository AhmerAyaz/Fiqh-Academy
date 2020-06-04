namespace Fiqh_Academy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Books : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "FileContent", c => c.Binary(nullable: false));
            DropColumn("dbo.Books", "FilePath");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "FilePath", c => c.String(nullable: false));
            DropColumn("dbo.Books", "FileContent");
        }
    }
}
