namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Newtables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BirimAdi = c.String(nullable: false, maxLength: 10),
                        Aciklama = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Warehouses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepoAdi = c.String(nullable: false, maxLength: 20),
                        Aciklama = c.String(maxLength: 100),
                        DepoYetkilisi = c.String(maxLength: 30),
                        Telefon = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirmaAdi = c.String(nullable: false, maxLength: 25),
                        FirmaTuru = c.String(nullable: false, maxLength: 15),
                        Adres = c.String(maxLength: 100),
                        Telefon = c.String(maxLength: 15),
                        Email = c.String(maxLength: 20),
                        YetkiliKisi = c.String(maxLength: 30),
                        Aciklama = c.String(maxLength: 100),
                        VergiNo = c.String(maxLength: 15),
                        HesapNo = c.String(maxLength: 16),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(nullable: false, maxLength: 20),
                        Soyadi = c.String(nullable: false, maxLength: 20),
                        Gorevi = c.String(nullable: false, maxLength: 20),
                        KullaniciAdi = c.String(nullable: false, maxLength: 20),
                        Sifre = c.String(nullable: false, maxLength: 20),
                        AktifMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Categories", "Description", c => c.String(maxLength: 200));
            AddColumn("dbo.Products", "Adi", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Products", "BarkodKodu", c => c.String(maxLength: 15));
            AddColumn("dbo.Products", "StokMiktari", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "UnitId", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "BirimFiyat", c => c.Double(nullable: false));
            AddColumn("dbo.Products", "WarehouseId", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "RafNo", c => c.String(maxLength: 5));
            AddColumn("dbo.Products", "MinStok", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "MaxStok", c => c.Int(nullable: false));
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false, maxLength: 30));
            CreateIndex("dbo.Products", "CategoryId");
            CreateIndex("dbo.Products", "UnitId");
            CreateIndex("dbo.Products", "WarehouseId");
            AddForeignKey("dbo.Products", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Products", "UnitId", "dbo.Units", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Products", "WarehouseId", "dbo.Warehouses", "Id", cascadeDelete: true);
            DropColumn("dbo.Products", "Name");
            DropTable("dbo.Depoes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Depoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Products", "Name", c => c.String());
            DropForeignKey("dbo.Products", "WarehouseId", "dbo.Warehouses");
            DropForeignKey("dbo.Products", "UnitId", "dbo.Units");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "WarehouseId" });
            DropIndex("dbo.Products", new[] { "UnitId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            AlterColumn("dbo.Categories", "Name", c => c.String());
            DropColumn("dbo.Products", "MaxStok");
            DropColumn("dbo.Products", "MinStok");
            DropColumn("dbo.Products", "RafNo");
            DropColumn("dbo.Products", "WarehouseId");
            DropColumn("dbo.Products", "BirimFiyat");
            DropColumn("dbo.Products", "UnitId");
            DropColumn("dbo.Products", "StokMiktari");
            DropColumn("dbo.Products", "BarkodKodu");
            DropColumn("dbo.Products", "Adi");
            DropColumn("dbo.Categories", "Description");
            DropTable("dbo.Employees");
            DropTable("dbo.Companies");
            DropTable("dbo.Warehouses");
            DropTable("dbo.Units");
        }
    }
}
