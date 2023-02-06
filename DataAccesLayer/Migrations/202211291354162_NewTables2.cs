namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTables2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StockOperationDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StockOperationId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Byte(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.StockOperations", t => t.StockOperationId, cascadeDelete: true)
                .Index(t => t.StockOperationId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.StockOperations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyId = c.Int(nullable: false),
                        StockOperationType = c.String(nullable: false, maxLength: 20),
                        OperationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: true)
                .Index(t => t.CompanyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StockOperationDetails", "StockOperationId", "dbo.StockOperations");
            DropForeignKey("dbo.StockOperations", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.StockOperationDetails", "ProductId", "dbo.Products");
            DropIndex("dbo.StockOperations", new[] { "CompanyId" });
            DropIndex("dbo.StockOperationDetails", new[] { "ProductId" });
            DropIndex("dbo.StockOperationDetails", new[] { "StockOperationId" });
            DropTable("dbo.StockOperations");
            DropTable("dbo.StockOperationDetails");
        }
    }
}
