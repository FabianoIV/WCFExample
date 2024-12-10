using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;

namespace Wcf.Models
{
    internal sealed class Configuration : DbMigrationsConfiguration<AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AppDbContext context)
        {
            context.Invoices.AddOrUpdate(
                new Invoice
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000001"),
                    Number = "FV/2020/01",
                    Seller = "Firma Handlowa",
                    Buyer = "Klient",
                    NIP = "1234567890",
                    Positions = new List<InvoicePosition>
                    {
                        new InvoicePosition
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000011"),
                            Name = "Produkt 1",
                            PKUIW = "1234567890",
                            Count = 1,
                            Unit = "szt.",
                            UnitPrice = 100,
                            VAT = 23
                        },
                        new InvoicePosition
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000012"),
                            Name = "Produkt 2",
                            PKUIW = "0987654321",
                            Count = 2,
                            Unit = "szt.",
                            UnitPrice = 50,
                            VAT = 23
                        }
                    }
                }
            );
        }
    }
}
