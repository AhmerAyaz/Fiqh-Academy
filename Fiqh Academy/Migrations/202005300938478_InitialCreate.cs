namespace Fiqh_Academy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bayanaats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category = c.String(nullable: false),
                        Speaker = c.String(nullable: false, maxLength: 40),
                        Topic = c.String(nullable: false),
                        Size = c.Int(nullable: false),
                        Date = c.String(nullable: false),
                        FilePath = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category = c.String(nullable: false),
                        Speaker = c.String(nullable: false, maxLength: 40),
                        Topic = c.String(nullable: false),
                        Size = c.Int(nullable: false),
                        Date = c.String(nullable: false),
                        FilePath = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Date = c.String(nullable: false),
                        Duration = c.String(nullable: false),
                        Timings = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Registrations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false),
                        Name = c.String(nullable: false, maxLength: 40),
                        LName = c.String(nullable: false),
                        Number = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Updates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                        Number = c.Int(nullable: false),
                        Email = c.String(nullable: false),
                        ContactType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Updates");
            DropTable("dbo.Registrations");
            DropTable("dbo.Courses");
            DropTable("dbo.Books");
            DropTable("dbo.Bayanaats");
        }
    }
}
