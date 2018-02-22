namespace systemBuy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tableSideBuy : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.sideBuys",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nameSide = c.String(nullable: false),
                        descriptions = c.String(nullable: false),
                        addressSide = c.String(nullable: false),
                        sideBuy_id = c.Int(nullable: false),
                        bill_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.bills", t => t.bill_id)
                .Index(t => t.bill_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.sideBuys", "bill_id", "dbo.bills");
            DropIndex("dbo.sideBuys", new[] { "bill_id" });
            DropTable("dbo.sideBuys");
        }
    }
}
