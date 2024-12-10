using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using Wcf.Models;
using Wcf.ServiceContract;

namespace Wcf.Server
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class MessageService : IMessageService
    {
        public List<Invoice> GetInvoices()
        {
            List<Invoice> result = null;

            using (var context = new AppDbContext())
            {
                result = context.Invoices.Include("Positions").ToList();
            }

            return result;
        }

        public void CreateInvoice(Invoice invoice)
        {
            invoice.Id = Guid.NewGuid();

            using (var context = new AppDbContext())
            {
                context.Invoices.Add(invoice);
                context.SaveChanges();
            }
        }

        public Invoice GetInvoice(Guid id)
        {
            using (var context = new AppDbContext())
            {
                var result = context.Invoices.Include("Positions").Single(i => i.Id == id);
                return result;
            }
        }

        public bool UpdateInvoice(Invoice invoice)
        {
            using (var context = new AppDbContext())
            {
                var existingInvoice = context.Invoices.Single(i => i.Id == invoice.Id);
                existingInvoice.Number = invoice.Number;
                existingInvoice.NIP = invoice.NIP;
                existingInvoice.Seller = invoice.Seller;
                existingInvoice.Buyer = invoice.Buyer;
                context.SaveChanges();
            }

            return true;
        }

        public bool DeleteInvoice(Guid id)
        {
            using (var context = new AppDbContext())
            {
                var invoice = context.Invoices.Single(i => i.Id == id);
                context.Invoices.Remove(invoice);
                context.SaveChanges();
            }

            return true;
        }
    }
}
