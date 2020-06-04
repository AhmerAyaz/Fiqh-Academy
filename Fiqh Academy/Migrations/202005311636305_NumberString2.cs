namespace Fiqh_Academy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NumberString2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Updates", "Number", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Updates", "Number", c => c.Int(nullable: false));
        }
    }
}
