namespace Wcf.Models
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedInvoceForeignKeyToInvoicePosition : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.InvoicePositions", "Invoice_Id", "dbo.Invoices");
            DropIndex("dbo.InvoicePositions", new[] { "Invoice_Id" });
            RenameColumn(table: "dbo.InvoicePositions", name: "Invoice_Id", newName: "InvoiceId");
            AlterColumn("dbo.InvoicePositions", "InvoiceId", c => c.Guid(nullable: false));
            CreateIndex("dbo.InvoicePositions", "InvoiceId");
            AddForeignKey("dbo.InvoicePositions", "InvoiceId", "dbo.Invoices", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InvoicePositions", "InvoiceId", "dbo.Invoices");
            DropIndex("dbo.InvoicePositions", new[] { "InvoiceId" });
            AlterColumn("dbo.InvoicePositions", "InvoiceId", c => c.Guid());
            RenameColumn(table: "dbo.InvoicePositions", name: "InvoiceId", newName: "Invoice_Id");
            CreateIndex("dbo.InvoicePositions", "Invoice_Id");
            AddForeignKey("dbo.InvoicePositions", "Invoice_Id", "dbo.Invoices", "Id");
        }
    }
}
