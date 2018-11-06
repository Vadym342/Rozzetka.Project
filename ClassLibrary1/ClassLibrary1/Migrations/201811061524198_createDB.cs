namespace ClassLibrary1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Town = c.String(),
                        Street = c.String(),
                        Suppliers_ID = c.Int(),
                        Producers_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Suppliers", t => t.Suppliers_ID)
                .ForeignKey("dbo.Producers", t => t.Producers_ID)
                .Index(t => t.Suppliers_ID)
                .Index(t => t.Producers_ID);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Addresses_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Addresses", t => t.Addresses_ID)
                .Index(t => t.Addresses_ID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Products_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Products", t => t.Products_ID)
                .Index(t => t.Products_ID);
            
            CreateTable(
                "dbo.Deliveries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QuantityinStorage = c.Int(nullable: false),
                        Sales_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Sales", t => t.Sales_ID)
                .Index(t => t.Sales_ID);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Deliveries_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Deliveries", t => t.Deliveries_ID)
                .Index(t => t.Deliveries_ID);
            
            CreateTable(
                "dbo.Producers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ProductsDeliveries",
                c => new
                    {
                        Products_ID = c.Int(nullable: false),
                        Deliveries_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Products_ID, t.Deliveries_ID })
                .ForeignKey("dbo.Products", t => t.Products_ID, cascadeDelete: true)
                .ForeignKey("dbo.Deliveries", t => t.Deliveries_ID, cascadeDelete: true)
                .Index(t => t.Products_ID)
                .Index(t => t.Deliveries_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Sales_ID", "dbo.Sales");
            DropForeignKey("dbo.Addresses", "Producers_ID", "dbo.Producers");
            DropForeignKey("dbo.Suppliers", "Deliveries_ID", "dbo.Deliveries");
            DropForeignKey("dbo.Addresses", "Suppliers_ID", "dbo.Suppliers");
            DropForeignKey("dbo.ProductsDeliveries", "Deliveries_ID", "dbo.Deliveries");
            DropForeignKey("dbo.ProductsDeliveries", "Products_ID", "dbo.Products");
            DropForeignKey("dbo.Categories", "Products_ID", "dbo.Products");
            DropForeignKey("dbo.Countries", "Addresses_ID", "dbo.Addresses");
            DropIndex("dbo.ProductsDeliveries", new[] { "Deliveries_ID" });
            DropIndex("dbo.ProductsDeliveries", new[] { "Products_ID" });
            DropIndex("dbo.Suppliers", new[] { "Deliveries_ID" });
            DropIndex("dbo.Products", new[] { "Sales_ID" });
            DropIndex("dbo.Categories", new[] { "Products_ID" });
            DropIndex("dbo.Countries", new[] { "Addresses_ID" });
            DropIndex("dbo.Addresses", new[] { "Producers_ID" });
            DropIndex("dbo.Addresses", new[] { "Suppliers_ID" });
            DropTable("dbo.ProductsDeliveries");
            DropTable("dbo.Sales");
            DropTable("dbo.Producers");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Products");
            DropTable("dbo.Deliveries");
            DropTable("dbo.Categories");
            DropTable("dbo.Countries");
            DropTable("dbo.Addresses");
        }
    }
}
