namespace Fiqh_Academy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NumberString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Registrations", "Number", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Registrations", "Number", c => c.Int(nullable: false));
        }
    }
}
