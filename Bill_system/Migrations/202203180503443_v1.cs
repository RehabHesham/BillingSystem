namespace Bill_system.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        compan_id = c.Int(nullable: false, identity: true),
                        company_name = c.String(nullable: false, maxLength: 150),
                        company_notes = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.compan_id)
                .Index(t => t.company_name, unique: true);
            
            CreateTable(
                "dbo.Type_p",
                c => new
                    {
                        typ_id = c.Int(nullable: false, identity: true),
                        typ_name = c.String(nullable: false, maxLength: 150),
                        typ_notes = c.String(maxLength: 500),
                        company_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.typ_id)
                .ForeignKey("dbo.Companies", t => t.company_id, cascadeDelete: true)
                .Index(t => t.typ_name, unique: true)
                .Index(t => t.company_id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        item_Code = c.Int(nullable: false, identity: true),
                        item_name = c.String(nullable: false, maxLength: 150),
                        item_notes = c.String(maxLength: 500),
                        buy_price = c.Decimal(nullable: false, storeType: "money"),
                        sell_price = c.Decimal(nullable: false, storeType: "money"),
                        type_id = c.Int(nullable: false),
                        unit_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.item_Code)
                .ForeignKey("dbo.Type_p", t => t.type_id, cascadeDelete: true)
                .ForeignKey("dbo.Units", t => t.unit_id, cascadeDelete: true)
                .Index(t => t.item_name, unique: true)
                .Index(t => t.type_id)
                .Index(t => t.unit_id);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        unt_id = c.Int(nullable: false, identity: true),
                        unt_name = c.String(nullable: false, maxLength: 150),
                        unt_notes = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.unt_id)
                .Index(t => t.unt_name, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "unit_id", "dbo.Units");
            DropForeignKey("dbo.Items", "type_id", "dbo.Type_p");
            DropForeignKey("dbo.Type_p", "company_id", "dbo.Companies");
            DropIndex("dbo.Units", new[] { "unt_name" });
            DropIndex("dbo.Items", new[] { "unit_id" });
            DropIndex("dbo.Items", new[] { "type_id" });
            DropIndex("dbo.Items", new[] { "item_name" });
            DropIndex("dbo.Type_p", new[] { "company_id" });
            DropIndex("dbo.Type_p", new[] { "typ_name" });
            DropIndex("dbo.Companies", new[] { "company_name" });
            DropTable("dbo.Units");
            DropTable("dbo.Items");
            DropTable("dbo.Type_p");
            DropTable("dbo.Companies");
        }
    }
}
