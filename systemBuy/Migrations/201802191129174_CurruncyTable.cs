namespace systemBuy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CurruncyTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CurruncyUnits",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        descriptions = c.String(nullable: false),
                        curruncy_id = c.Int(nullable: false),
                        bills_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.bills", t => t.bills_id)
                .Index(t => t.bills_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CurruncyUnits", "bills_id", "dbo.bills");
            DropIndex("dbo.CurruncyUnits", new[] { "bills_id" });
            DropTable("dbo.CurruncyUnits");
        }
    }
}
