namespace systemBuy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class itemTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.items",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nameItem = c.String(nullable: false),
                        descriptions = c.String(nullable: false),
                        brand = c.String(nullable: false),
                        serialNamber = c.String(nullable: false),
                        barcode = c.String(nullable: false),
                        Itembills_id = c.Int(nullable: false),
                        bills_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.bills", t => t.bills_id)
                .Index(t => t.bills_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.items", "bills_id", "dbo.bills");
            DropIndex("dbo.items", new[] { "bills_id" });
            DropTable("dbo.items");
        }
    }
}
