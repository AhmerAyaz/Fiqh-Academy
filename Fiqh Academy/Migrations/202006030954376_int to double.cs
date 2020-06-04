namespace Fiqh_Academy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inttodouble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bayanaats", "Size", c => c.Double(nullable: false));
            AlterColumn("dbo.Books", "Size", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "Size", c => c.Int(nullable: false));
            AlterColumn("dbo.Bayanaats", "Size", c => c.Int(nullable: false));
        }
    }
}
