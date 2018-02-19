namespace systemBuy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class billsTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.bills", "NameBuy", c => c.String(nullable: false));
            AlterColumn("dbo.bills", "billNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.bills", "billNumber", c => c.String());
            AlterColumn("dbo.bills", "NameBuy", c => c.String());
        }
    }
}
