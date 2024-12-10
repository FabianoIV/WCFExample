namespace Wcf.Models
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InvoicePositions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        PKUIW = c.String(),
                        Count = c.Int(nullable: false),
                        Unit = c.String(),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        VAT = c.Int(nullable: false),
                        Invoice_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Invoices", t => t.Invoice_Id)
                .Index(t => t.Invoice_Id);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Number = c.String(),
                        NIP = c.String(),
                        Seller = c.String(),
                        Buyer = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InvoicePositions", "Invoice_Id", "dbo.Invoices");
            DropIndex("dbo.InvoicePositions", new[] { "Invoice_Id" });
            DropTable("dbo.Invoices");
            DropTable("dbo.InvoicePositions");
        }
    }
}
