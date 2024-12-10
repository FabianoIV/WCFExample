using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wcf.Models
{
    public class InvoicePosition
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PKUIW { get; set; }
        public int Count { get; set; }
        public string Unit { get; set; }
        public decimal UnitPrice { get; set; }
        public int VAT { get; set; }

        public Guid InvoiceId { get; set; }
    }
}
