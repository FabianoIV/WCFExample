using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wcf.Models
{
    public class Invoice
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public string NIP { get; set; }
        public string Seller { get; set; }
        public string Buyer { get; set; }

        public List<InvoicePosition> Positions { get; set; } = new List<InvoicePosition>();
    }
}
