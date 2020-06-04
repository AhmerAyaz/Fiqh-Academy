namespace Fiqh_Academy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FName = c.String(nullable: false, maxLength: 40),
                        LName = c.String(nullable: false, maxLength: 40),
                        Email = c.String(nullable: false, maxLength: 30),
                        Password = c.String(nullable: false, maxLength: 20),
                        CPassword = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Registrations", "CourseType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Registrations", "CourseType");
            DropTable("dbo.Logins");
        }
    }
}
