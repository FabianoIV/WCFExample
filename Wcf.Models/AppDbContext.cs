using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wcf.Models
{
    public class AppDbContext : DbContext
    {
        private static string ConnectionString = "Data Source=DESKTOP-VH1SCPJ;Initial Catalog=InvoiceApp;Integrated Security=True";

        public AppDbContext() 
            : base(ConnectionString)
        {
        }

        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoicePosition> InvoicePositions { get; set; }
    }
}
